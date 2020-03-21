namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type layer =
    /// Determines if the layer will be inserted before the layer with the specified ID. If omitted or set to '', the layer will be inserted above every existing layer.
    static member inline below (value: string) = Interop.mkLayerAttr "below" value
    static member inline circle (properties: #ICircleProperty list) = Interop.mkLayerAttr "circle" (createObj !!properties)
    /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
    static member inline color (value: string) = Interop.mkLayerAttr "color" value
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (value: bool) = Interop.mkLayerAttr "coordinates" value
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (values: seq<bool>) = Interop.mkLayerAttr "coordinates" (values |> ResizeArray)
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (value: System.DateTime) = Interop.mkLayerAttr "coordinates" value
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (values: seq<System.DateTime>) = Interop.mkLayerAttr "coordinates" (values |> ResizeArray)
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (value: int) = Interop.mkLayerAttr "coordinates" value
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (values: seq<int>) = Interop.mkLayerAttr "coordinates" (values |> ResizeArray)
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (value: float) = Interop.mkLayerAttr "coordinates" value
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (values: seq<float>) = Interop.mkLayerAttr "coordinates" (values |> ResizeArray)
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (value: string) = Interop.mkLayerAttr "coordinates" value
    /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
    static member inline coordinates (values: seq<string>) = Interop.mkLayerAttr "coordinates" (values |> ResizeArray)
    static member inline fill (properties: #IFillProperty list) = Interop.mkLayerAttr "fill" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkLayerAttr "line" (createObj !!properties)
    /// Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden.
    static member inline maxzoom (value: int) = Interop.mkLayerAttr "maxzoom" value
    /// Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden.
    static member inline maxzoom (value: float) = Interop.mkLayerAttr "maxzoom" value
    /// Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden.
    static member inline minzoom (value: int) = Interop.mkLayerAttr "minzoom" value
    /// Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden.
    static member inline minzoom (value: float) = Interop.mkLayerAttr "minzoom" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkLayerAttr "name" value
    /// Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)
    static member inline opacity (value: int) = Interop.mkLayerAttr "opacity" value
    /// Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)
    static member inline opacity (value: float) = Interop.mkLayerAttr "opacity" value
    /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
    static member inline source (value: string) = Interop.mkLayerAttr "source" (value |> Array.singleton)
    /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
    static member inline source (values: seq<string>) = Interop.mkLayerAttr "source" (values |> ResizeArray)
    /// Sets the attribution for this source.
    static member inline sourceattribution (value: string) = Interop.mkLayerAttr "sourceattribution" value
    /// Specifies the layer to use from a vector tile source (mapbox.layer.source-layer). Required for *vector* source type that supports multiple layers.
    static member inline sourcelayer (value: string) = Interop.mkLayerAttr "sourcelayer" value
    static member inline symbol (properties: #ISymbolProperty list) = Interop.mkLayerAttr "symbol" (createObj !!properties)
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkLayerAttr "templateitemname" value
    /// Determines whether this layer is displayed
    static member inline visible (value: bool) = Interop.mkLayerAttr "visible" value

[<RequireQualifiedAccess>]
module layer =
    /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
    [<Erase>]
    type color =
        /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
        static member inline rgb (r,g,b) = Interop.mkLayerAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
        static member inline rgba (r,g,b,a) = Interop.mkLayerAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
        static member inline hsl (h,s,l) = Interop.mkLayerAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the source type for this layer, that is the type of the layer data.
    [<Erase>]
    type sourcetype =
        static member inline geojson = Interop.mkLayerAttr "sourcetype" "geojson"
        static member inline image = Interop.mkLayerAttr "sourcetype" "image"
        static member inline raster = Interop.mkLayerAttr "sourcetype" "raster"
        static member inline vector = Interop.mkLayerAttr "sourcetype" "vector"

    /// Sets the layer type, that is the how the layer data set in `source` will be rendered With `sourcetype` set to *geojson*, the following values are allowed: *circle*, *line*, *fill* and *symbol*. but note that *line* and *fill* are not compatible with Point GeoJSON geometries. With `sourcetype` set to *vector*, the following values are allowed:  *circle*, *line*, *fill* and *symbol*. With `sourcetype` set to *raster* or `*image*`, only the *raster* value is allowed.
    [<Erase>]
    type type' =
        static member inline circle = Interop.mkLayerAttr "type" "circle"
        static member inline fill = Interop.mkLayerAttr "type" "fill"
        static member inline line = Interop.mkLayerAttr "type" "line"
        static member inline raster = Interop.mkLayerAttr "type" "raster"
        static member inline symbol = Interop.mkLayerAttr "type" "symbol"

