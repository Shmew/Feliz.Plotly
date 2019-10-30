namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type geo =
    static member inline domain (properties: #IDomainProperty list) = Interop.mkGeoAttr "domain" (createObj !!properties)
    static member inline projection (properties: #IProjectionProperty list) = Interop.mkGeoAttr "projection" (createObj !!properties)
    static member inline center (properties: #ICenterProperty list) = Interop.mkGeoAttr "center" (createObj !!properties)
    /// Sets whether or not the coastlines are drawn.
    static member inline showcoastlines (value: bool) = Interop.mkGeoAttr "showcoastlines" value
    /// Sets the coastline color.
    static member inline coastlinecolor (value: string) = Interop.mkGeoAttr "coastlinecolor" value
    /// Sets the coastline stroke width (in px).
    static member inline coastlinewidth (value: int) = Interop.mkGeoAttr "coastlinewidth" value
    /// Sets the coastline stroke width (in px).
    static member inline coastlinewidth (value: float) = Interop.mkGeoAttr "coastlinewidth" value
    /// Sets whether or not land masses are filled in color.
    static member inline showland (value: bool) = Interop.mkGeoAttr "showland" value
    /// Sets the land mass color.
    static member inline landcolor (value: string) = Interop.mkGeoAttr "landcolor" value
    /// Sets whether or not oceans are filled in color.
    static member inline showocean (value: bool) = Interop.mkGeoAttr "showocean" value
    /// Sets the ocean color
    static member inline oceancolor (value: string) = Interop.mkGeoAttr "oceancolor" value
    /// Sets whether or not lakes are drawn.
    static member inline showlakes (value: bool) = Interop.mkGeoAttr "showlakes" value
    /// Sets the color of the lakes.
    static member inline lakecolor (value: string) = Interop.mkGeoAttr "lakecolor" value
    /// Sets whether or not rivers are drawn.
    static member inline showrivers (value: bool) = Interop.mkGeoAttr "showrivers" value
    /// Sets color of the rivers.
    static member inline rivercolor (value: string) = Interop.mkGeoAttr "rivercolor" value
    /// Sets the stroke width (in px) of the rivers.
    static member inline riverwidth (value: int) = Interop.mkGeoAttr "riverwidth" value
    /// Sets the stroke width (in px) of the rivers.
    static member inline riverwidth (value: float) = Interop.mkGeoAttr "riverwidth" value
    /// Sets whether or not country boundaries are drawn.
    static member inline showcountries (value: bool) = Interop.mkGeoAttr "showcountries" value
    /// Sets line color of the country boundaries.
    static member inline countrycolor (value: string) = Interop.mkGeoAttr "countrycolor" value
    /// Sets line width (in px) of the country boundaries.
    static member inline countrywidth (value: int) = Interop.mkGeoAttr "countrywidth" value
    /// Sets line width (in px) of the country boundaries.
    static member inline countrywidth (value: float) = Interop.mkGeoAttr "countrywidth" value
    /// Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn.
    static member inline showsubunits (value: bool) = Interop.mkGeoAttr "showsubunits" value
    /// Sets the color of the subunits boundaries.
    static member inline subunitcolor (value: string) = Interop.mkGeoAttr "subunitcolor" value
    /// Sets the stroke width (in px) of the subunits boundaries.
    static member inline subunitwidth (value: int) = Interop.mkGeoAttr "subunitwidth" value
    /// Sets the stroke width (in px) of the subunits boundaries.
    static member inline subunitwidth (value: float) = Interop.mkGeoAttr "subunitwidth" value
    /// Sets whether or not a frame is drawn around the map.
    static member inline showframe (value: bool) = Interop.mkGeoAttr "showframe" value
    /// Sets the color the frame.
    static member inline framecolor (value: string) = Interop.mkGeoAttr "framecolor" value
    /// Sets the stroke width (in px) of the frame.
    static member inline framewidth (value: int) = Interop.mkGeoAttr "framewidth" value
    /// Sets the stroke width (in px) of the frame.
    static member inline framewidth (value: float) = Interop.mkGeoAttr "framewidth" value
    /// Set the background color of the map
    static member inline bgcolor (value: string) = Interop.mkGeoAttr "bgcolor" value
    static member inline lonaxis (properties: #ILonaxisProperty list) = Interop.mkGeoAttr "lonaxis" (createObj !!properties)
    static member inline lataxis (properties: #ILataxisProperty list) = Interop.mkGeoAttr "lataxis" (createObj !!properties)
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkGeoAttr "uirevision" value
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkGeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkGeoAttr "uirevision" value
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkGeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkGeoAttr "uirevision" value
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkGeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkGeoAttr "uirevision" value
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkGeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkGeoAttr "uirevision" value
    /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkGeoAttr "uirevision" (values |> Array.ofSeq)

[<AutoOpen>]
module geo =
    /// Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
    [<Erase>]
    type resolution =
        static member inline _110 = Interop.mkGeoAttr "resolution" "110"
        static member inline _50 = Interop.mkGeoAttr "resolution" "50"

    /// Set the scope of the map.
    [<Erase>]
    type scope =
        static member inline africa = Interop.mkGeoAttr "scope" "africa"
        static member inline asia = Interop.mkGeoAttr "scope" "asia"
        static member inline europe = Interop.mkGeoAttr "scope" "europe"
        static member inline northAmerica = Interop.mkGeoAttr "scope" "north america"
        static member inline southAmerica = Interop.mkGeoAttr "scope" "south america"
        static member inline usa = Interop.mkGeoAttr "scope" "usa"
        static member inline world = Interop.mkGeoAttr "scope" "world"

