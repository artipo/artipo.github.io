[<RequireQualifiedAccess>]
module Styles

open Fable.React.Props
open Fss

let myIcon =
  Class
  <| fss
    [
        Width' (rem 12.0)
        Height' (rem 12.0)
        MarginBottom' (px 6)
    ]