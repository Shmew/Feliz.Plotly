# Feliz.SweetAlert - Installation

To install `Feliz.SweetAlert` into your project, you need to install the nuget package into your F# project
```bash
# nuget
dotnet add package Feliz.SweetAlert
# paket
paket add Feliz.SweetAlert --project ./project/path
```
Then you need to install the corresponding npm dependencies. In case of Feliz.SweetAlert, it is `sweetalert2`, and `sweetalert2-react-content`
```bash
npm install sweetalert2
npm install sweetalert2-react-content

___

yarn add sweetalert2
yarn add sweetalert2-react-content
```

### Use Femto

If you happen to use [Femto](https://github.com/Zaid-Ajaj/Femto), then it can install everything for you in one go
```bash
cd ./project
femto install Feliz.SweetAlert
```
Here, the nuget package will be installed using the package manager that the project is using (detected by Femto) and then the required npm packages will be resolved

### Themes

You can install custom themes for SweetAlert2.

First you install the theme(s) you want:
```bash
npm install @sweetalert2/theme-<theme_name>
npm install @sweetalert2/themese (for all of them)

___

yarn add @sweetalert2/theme-<theme_name>
yarn add @sweetalert2/themese (for all of them)
```

Then in your css or scss:

```css
<link rel="stylesheet" href="@sweetalert2/themes/dark/dark.css">

___

@import '~@sweetalert2/themes/dark/dark.scss';
```
