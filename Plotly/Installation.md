# Feliz.Plotly - Installation

To install `Feliz.Plotly` into your project, you need to install the nuget package into your F# project
```bash
# nuget
dotnet add package Feliz.Plotly
# paket
paket add Feliz.Plotly --project ./project/path
```
Then you need to install the corresponding npm dependencies. In case of Feliz.Plotly, it is `react`, `react-dom`, `plotly.js`, and `react-plotly.js`
```bash
npm install react
npm install react-dom
npm install plotly.js
npm install react-plotly.js

___

yarn add react
yarn add react-dom
yarn add plotly.js
yarn add react-plotly.js
```

### Use Femto

If you happen to use [Femto](https://github.com/Zaid-Ajaj/Femto), then it can install everything for you in one go
```bash
cd ./project
femto install Feliz.Plotly
```
Here, the nuget package will be installed using the package manager that the project is using (detected by Femto) and then the required npm packages will be resolved

#### Webpack caveat

If you use [Webpack](https://webpack.js.org) you need to use [ify-loader](https://github.com/browserify/ify-loader) in your `webpack.config.js`:
```javascript
...
      module: {
          rules: [
              {
                  test: /\.js$/,
                  loader: 'ify-loader'
              }
          ]
      },
...
```
