### 2.1.0 - Thursday, June 17th, 2021
* Add support for DateTimeOffset

### 2.0.0 - Tuesday, June 8th, 2021
* Update for plotly.js 2.0.0 release

### 1.7.0 - Friday, December 4th, 2020
* Update for plotly.js 1.58.0 release

### 1.6.1 - Wednesday, November 18th, 2020
* Support FSharp.Core 5.0

### 1.6.0 - Tuesday, October 10th, 2020
* Update for plotly.js 1.57.0 release

### 1.5.0 - Sunday, October 4th, 2020
* Update for plotly.js 1.56.0 release

### 1.4.1 - Sunday, September 20th, 2020
* Fix issue with axis rangebreaks

### 1.4.0 - Monday, September 15th, 2020
* Update for react-plotly.js 2.5.0 release

### 1.3.0 - Wednesday, September 2nd, 2020
* Update for plotly.js 1.55.1 release

### 1.2.0 - Friday, May 22nd, 2020
* Fix toImageButtonOptions signature resolution
* Fixed localization signature resolution
* Added pre-defined locales and hooks to make locale registration easier

### 1.1.0 - Friday, May 22nd, 2020
* Add Plot.toImage

### 1.0.2 - Friday, May 22nd, 2020
* Fix fable packaging

### 1.0.1 - Wednesday, May 20th, 2020
* Fix Feliz version range restriction

### 1.0.0 - Wednesday, May 20th, 2020
* Stable release
* Adds support for programmatic downloads

### 0.22.0 - Tuesday, April 30th, 2020
* Regenerate for plotly.js 1.54.0 release

### 0.21.0 - Tuesday, March 31st, 2020
* Regenerate for plotly.js 1.53.0 release

### 0.20.1 - Saturday, March 21st, 2020
* Remove duplicate prop files

### 0.20.0 - Saturday, March 21st, 2020
* Added event union active patterns
* Added syntax sugar for `_.title` to accept a string
* Added syntax sugar for `_.color` to allow things such as: `marker.color.rgb (255, 255, 255)` as opposed to `marker.color (color.rgb (255, 255, 255))`
* Added proper event bindings
* Added support for trace templating
* Added additional string enum bindings
* Some performance optimizations
* Made transforms not require only strings
* Changed module accessibility to avoid intellisense bloat
* Fixed potential namespace collisions
* Fixed modebar button functions not accepting normal plotly button objects
* Fixed map plot serialization issues
* Fixed transform serialization issues
* Fixed 3D plot serialization issues

### 0.19.0 - Wednesday, January 8, 2020
* Regenerate for plotly.js 1.52.0 release

### 0.18.4 - Saturday, November 22, 2019
* Regenerate for plotly.js 1.51.2 release

### 0.18.3 - Saturday, November 22, 2019
* Change import statement to fix issue with some webgl not importing properly

### 0.18.2 - Friday, November 22, 2019
* Added modeBarButton static typings

### 0.18.1 - Friday, November 22, 2019
* Fixed base plot style attribute

### 0.18.0 - Thursday, November 21, 2019
* Fixed layout buttons not being properly parsed

### 0.17.2 - Saturday, November 16, 2019
* Fix nupkg

### 0.17.0 - Saturday, November 9, 2019
* Updated for latest Plotly releases
* Fixed radial and angular data types not being set correctly
* Added additional static typings for ref properties (this should be all of them) 

### 0.16.0 - Saturday, November 9, 2019
* Added additional static typings for ref properties
* Removed some deprecated properties
* Fixed some layout options not being where they should

### 0.15.0 - Tuesday, November 4, 2019
* Add static typings for many properties
* Created the `PlotData` type to deal with multiple typed inputs for 2D collections

### 0.14.1 - Tuesday, November 4, 2019
* Fixed bool enum values not working properly
* Added typed support for style transformations

### 0.14.0 - Monday, November 4, 2019
* Fixed some nested enum values not getting overloads generated
* Added proper support for plot events

### 0.13.0 - Saturday, November 2, 2019
* Changed enumerated arrays to be more consistent with the rest of the api
* Fixed some overloads not being present
* Added support for option primatives in data input props

### 0.12.0 - Friday, November 1, 2019
* Fixed some attributes being cast to the wrong JS type

### 0.11.0 - Thursday, October 31, 2019
* Added support for custom colorscaling, and fixed api for colorscaling

### 0.10.1 - Wednesday, October 30, 2019
* Fixed an issue where some deeply nested properties didn't get compiled for some attributes

### 0.10.0 - Wednesday, October 30, 2019
* Added support for DateTime where applicable
* Compiled against latest Feliz version

### 0.9.0 - Tuesday, October 29, 2019
* Fixed some properties that were not accepting 2D collections when they should have
* Added support for 2D collections of different primative types

### 0.8.1 - Sunday, October 27, 2019
* Added support for 2D collections

### 0.8.0 - Sunday, October 27, 2019
* Reimplemented how flaglists are handled

### 0.7.0 - Saturday, October 26, 2019
* Added singleton support for values that only accept arrays
  Meaning if you have a single value you can just pass in the value without brackets
* Filtered out additional deprecated methods
* Added support for multiple layout.xaxis and layout.yaxis
* Fixed some attributes that required Float32 typed arrays

### 0.6.1 - Saturday, October 26, 2019
* Fix subplotid implementation

### 0.6.0 - Friday, October 25, 2019
* Reimplemented code generation to be significantly smaller and easier to use. 
  No more namespace collisions, as well as fixed some issues with layoutAttribute specific values.

### 0.5.0 - Monday, October 21, 2019
* Added support for layout specific attributes

### 0.4.1 - Saturday, October 19, 2019
* Fix package metadata

### 0.4.0 - Saturday, October 19, 2019
* Fixed nested objects that then expected an array

### 0.3.0 - Friday, October 18, 2019
* Removed conditional overloads now that FSharp.Core supports implicit yields
* Added more documentation to Plotly.Generator
* Replaced instances of snake_case in the api with camelCase

### 0.2.1 - Thursday, October 17, 2019
* Cleaned up intellisense

### 0.2.0 - Thursday, October 17, 2019
* Added support for enum arrays
* Made very nested types usable

### 0.1.1 - Thursday, October 17, 2019
* Fixed seq primative inputs

### 0.1.0 - Thursday, October 17, 2019
* Fixed nested properties not being accessible, reduced required verbosity of syntax

### 0.0.3 - Wednesday, October 16, 2019
* Change targeting to netstandard2.0

### 0.0.2 - Wednesday, October 16, 2019
* Added seq to methods that have arrayOK set to true

### 0.0.1 - Saturday, October 12, 2019
* Initial build
