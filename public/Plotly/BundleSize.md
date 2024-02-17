# Feliz.Plotly - Reducing Bundle Size

The library itself references the global plotly.js library to ensure all features are available, but when it's time to use in production  it is a heafty load coming in at about 1MB minified and gzipped.

Luckily there is an easy resolution for this, webpack module aliasing.

The plotly.js team has a [variety of reduced functionality distributions](https://github.com/plotly/plotly.js/blob/master/dist/README.md#partial-bundles) that you can then alias to significantly reduce bundle size.

You only need to make this change:

```js
module.exports = {
    ...
    resolve: {
        alias: {
            'plotly.js/dist/plotly': path.join(__dirname, 'node_modules/plotly.js/dist/plotly-cartesian.min.js')
        }
    },
    ...
}
```

You will just need to replace `plotly-cartesian.min.js` with whichever bundle best suits your needs.
