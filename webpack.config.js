var path = require('path');
var webpack = require('webpack');
var HtmlWebpackPlugin = require('html-webpack-plugin');
var CopyWebpackPlugin = require('copy-webpack-plugin');
var MiniCssExtractPlugin = require("mini-css-extract-plugin");
const ReactRefreshWebpackPlugin = require('@pmmmwh/react-refresh-webpack-plugin');
const { patchGracefulFileSystem } = require("./webpack.common.js");
patchGracefulFileSystem();

var CONFIG = {
    indexHtmlTemplate: './src/index.html',
    fsharpEntry: 'docs/App.fs.js',
    outputDir: './dist',
    assetsDir: './public',
    devServerPort: 8080,
    // Use babel-preset-env to generate JS compatible with most-used browsers.
    // More info at https://babeljs.io/docs/en/next/babel-preset-env.html
    babel: {
        presets: [
            ['@babel/preset-env', {
                modules: false,
                // This adds polyfills when needed. Requires core-js dependency.
                // See https://babeljs.io/docs/en/babel-preset-env#usebuiltins
                // Note that you still need to add custom polyfills if necessary (e.g. whatwg-fetch)
                useBuiltIns: 'usage',
                corejs: 3
            }, "@babel/preset-react"]
        ],
    }
}

// If we're running the webpack-dev-server, assume we're in development mode
var isProduction = !process.argv.find(v => v.indexOf('webpack-dev-server') !== -1);
console.log('Bundling for ' + (isProduction ? 'production' : 'development') + '...');

var commonPlugins = [
    new HtmlWebpackPlugin({
        filename: 'index.html',
        template: resolve(CONFIG.indexHtmlTemplate)
    })
];

module.exports = {
    entry: {
        app: [resolve(CONFIG.fsharpEntry)]
    },
    output: {
        path: resolve(CONFIG.outputDir),
        filename: isProduction ? 'bundle.[name].[chunkhash].js' : 'bundle.[name].js',
    },
    mode: isProduction ? 'production' : 'development',
    devtool: isProduction ? 'source-map' : 'eval-source-map',
    optimization: {
        // Split the code coming from npm packages into a different file.
        // 3rd party dependencies change less often, let the browser cache them.
        splitChunks: {
            cacheGroups: {
                commons: {
                    test: /node_modules/,
                    name: "vendors",
                    chunks: "all"
                }
            }
        },
    },
    plugins: isProduction ?
        commonPlugins.concat([
            new MiniCssExtractPlugin({ filename: 'style.[contenthash].css' }),
            new CopyWebpackPlugin({
                patterns: [
                    { from: resolve(CONFIG.assetsDir) }
                ]
            }),
        ])
        : commonPlugins.concat([
            new ReactRefreshWebpackPlugin()
        ]),
    resolve: {
        // See https://github.com/fable-compiler/Fable/issues/1490
        symlinks: false,
        modules: [resolve("./node_modules")],
        alias: {
            // Some old libraries still use an old specific version of core-js
            // Redirect the imports of these libraries to the newer core-js
            'core-js/es6': 'core-js/es'
        }
    },
    devServer: {
        hot: true,
        port: CONFIG.devServerPort,
        static: {
            directory: resolve(CONFIG.assetsDir),
            publicPath: CONFIG.outputDir,
            publicPath: "/",
            serveIndex: true,
            watch: true,
        }
    },
    stats: {
        errorDetails: true
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: CONFIG.babel
                },
            },
            {
                test: /\.(sass|scss|css)$/,
                use: [
                    isProduction
                        ? MiniCssExtractPlugin.loader
                        : 'style-loader',
                    {
                        loader: 'css-loader',
                    },
                    {
                        loader: 'sass-loader',
                        options: { implementation: require("sass") }
                    }
                ],
            },
            {
                test: /\.(png|jpg|jpeg|gif|svg|woff|woff2|ttf|eot|md)(\?.*)?$/,
                use: ["file-loader"]
            }
        ]
    }
};

function resolve(filePath) {
    return path.isAbsolute(filePath) ? filePath : path.join(__dirname, filePath);
}