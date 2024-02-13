# Feliz.Plotly - Installation

To install `Feliz.Plotly` into your project, you need to install the nuget package into your F# project
```bash
# nuget
dotnet add package Feliz.Plotly
# paket
paket add Feliz.Plotly --project ./project/path
```
Then you need to install the corresponding npm dependencies. In case of Feliz.Plotly, it is `react`, `react-dom`, `plotly.js`, and `react-plotly.js`.

You probably already have react and react-dom installed if you're using any kind of template, you can skip those steps if so.

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

### Issues

If you have any trouble getting plotly to work after these steps, **make sure your fable-compiler and other dependencies are updated!**

If the problem isn't resolved after this please create an [issue](https://github.com/EverybodyKurts/Feliz.Plotly/issues/new/choose) and we can take a look.
