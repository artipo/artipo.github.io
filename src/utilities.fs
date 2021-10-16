module App.utilities

open Fable.React
open Fable.React.Props
open Fss

let classes names =
    names
    |> String.concat " "
    |> Class

// css shorthands
let padding_4 left right top bottom =
    [ PaddingLeft' left
      PaddingRight' right
      PaddingTop' top
      PaddingBottom' bottom ]

let padding_2 hor ver =
    padding_4 hor hor ver ver

let padding_1 tot =
    padding_2 tot tot

let padding_hor_2 left right =
    [ PaddingLeft' left
      PaddingRight' right ]

let padding_hor_1 hor =
    padding_hor_2 hor hor

let margin_4 left right top bottom =
    [ MarginLeft' left
      MarginRight' right
      MarginTop' top
      MarginBottom' bottom ]

let margin_2 hor ver =
    margin_4 hor hor ver ver

let margin_1 tot =
    margin_2 tot tot

let margin_hor_2 left right =
    [ MarginLeft' left
      MarginRight' right ]

let margin_hor_1 hor =
    margin_hor_2 hor hor

let margin_ver_2 top bottom =
    [ MarginTop' top
      MarginBottom' bottom ]

let margin_ver_1 ver =
    margin_ver_2 ver ver

let border_solid_3 width color radius =
    [ BorderWidth' width
      BorderStyle.solid
      BorderColor' color
      BorderRadius' radius]