#### 0.0.1 - Saturday, October 12, 2019
* Initial build

### 0.0.2 - Wednesday, October 16, 2019
* Added seq to methods that have arrayOK set to true

### 0.0.3 - Wednesday, October 16, 2019
* Change targeting to netstandard2.0

### 0.1.0 - Thursday, October 17, 2019
* Fixed nested properties not being accessible, reduced required verbosity of syntax

### 0.1.1 - Thursday, October 17, 2019
* Fixed seq primative inputs

### 0.2.0 - Thursday, October 17, 2019
* Added support for enum arrays
* Made very nested types usable

### 0.2.1 - Thursday, October 17, 2019
* Cleaned up intellisense

### 0.3.0 - Friday, October 18, 2019
* Removed conditional overloads now that FSharp.Core supports implicit yields
* Added more documentation to Plotly.Generator
* Replaced instances of snake_case in the api with camelCase

### 0.4.0 - Saturday, October 19, 2019
* Fixed nested objects that then expected an array

### 0.4.1 - Saturday, October 19, 2019
* Fix package metadata

### 0.5.0 - Monday, October 21, 2019
* Added support for layout specific attributes

### 0.6.0 - Friday, October 25, 2019
* Reimplemented code generation to be significantly smaller and easier to use. 
  No more namespace collisions, as well as fixed some issues with layoutAttribute specific values.

### 0.6.1 - Saturday, October 26, 2019
* Fix subplotid implementation

### 0.7.0 - Saturday, October 26, 2019
* Added singleton support for values that only accept arrays
  Meaning if you have a single value you can just pass in the value without brackets
* Filtered out additional deprecated methods
* Added support for multiple layout.xaxis and layout.yaxis
* Fixed some attributes that required Float32 typed arrays

### 0.8.0 - Sunday, October 27, 2019
* Reimplemented how flaglists are handled

### 0.8.1 - Sunday, October 27, 2019
* Added support for 2D collections

### 0.9.0 - Tuesday, October 29, 2019
* Fixed some properties that were not accepting 2D collections when they should have
* Added support for 2D collections of different primative types

### 0.10.0 - Wednesday, October 30, 2019
* Added support for DateTime where applicable
* Compiled against latest Feliz version

### 0.10.1 - Wednesday, October 30, 2019
* Fixed an issue where some deeply nested properties didn't get compiled for some attributes

### 0.11.0 - Thursday, October 31, 2019
* Added support for custom colorscaling, and fixed api for colorscaling