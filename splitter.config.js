const path = require("path");

module.exports = {
    entry: path.join(__dirname, "./docs/App.fsproj"),
    outDir: path.join(__dirname, "./dist"),
    babel: {
        plugins: ["@babel/plugin-transform-modules-commonjs"],
    }
};