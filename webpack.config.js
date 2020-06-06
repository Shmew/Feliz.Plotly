var path = require('path');
var webpack = require('webpack');
var HtmlWebpackPlugin = require('html-webpack-plugin');

var CONFIG = {
    indexHtmlTemplate: 'public/index.html',
    fsharpEntry: 'docs/App.fsproj',
    outputDir: 'public',
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
            }]
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
    entry: resolve(CONFIG.fsharpEntry),
    output: {
        path: resolve(CONFIG.outputDir),
        filename: 'bundle.[hash].js',
    },
    mode: isProduction ? 'production' : 'development',
    devtool: isProduction ? 'source-map' : 'eval-source-map',
    optimization: {
        runtimeChunk: 'single',
        splitChunks: {
            chunks: 'all'
        },
    },
    plugins: isProduction ?
        commonPlugins.concat([])
        : commonPlugins.concat([
            new webpack.HotModuleReplacementPlugin()
        ]),
    resolve: {
        // See https://github.com/fable-compiler/Fable/issues/1490
        symlinks: false
    },
    devServer: {
        contentBase: CONFIG.outputDir,
        hot: true,
        inline: true,
        port: CONFIG.devServerPort
    },
    module: {
        rules: [
            {
                test: /\.fs(x|proj)?$/,
                use: {
                    loader: 'fable-loader',
                    options: {
                        define: isProduction ? [] : ['DEBUG']
                    }
                }
            },
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: CONFIG.babel
                }
            },
            {
                test: /\.(png|jpg|jpeg|gif|svg|woff|woff2|ttf|eot|md)(\?.*)?$/,
                use: ['file-loader']
            }
        ]
    }
};

function resolve(filePath) {
    return path.join(__dirname, filePath);
}