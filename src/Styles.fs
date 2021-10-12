[<RequireQualifiedAccess>]
module Styles

open Fss
open Fss.FssTypes

// colors
let page_background_color = rgb 238 238 238
let page_foreground_color = rgb 51 51 51
let page_separator_color = rgb 153 153 153
let panel_background_color = rgb 221 221 221
let panel_foreground_color = rgb 51 51 51
let panel_foreground_color_hovered = rgb 125 125 125
let accent_color = rgb 249 149 80
let accent_foreground_color = rgb 51 51 51

// sizes
let private page_width = px 1100
let private screen_height = vh 100.0
let private fill_height = pct 100
let private fill_width = fill_height
let private social_icon_size = rem 2.

// paddings
let private padding_base' = rem 1.
let private padding_button_hor = rem 0.5
let private padding_button_ver = rem 0.2
let private padding_social_icon = rem 0.5
let private padding_portrait_card_hor = rem 1.
let private padding_portrait_card_ver = rem 2.

// margins
let private margin_base' = rem 1.
let private margin_big' = rem 3.

// infrastructure
let page_theme =
    fss [ BackgroundColor' page_background_color
          Color' page_foreground_color
          Label' "_page_theme" ]

let panel_theme =
    fss [ BackgroundColor' panel_background_color
          Color' panel_foreground_color
          Label' "_panel_theme" ]

let paginated =
    fss [ MaxWidth' page_width
          Margin.auto
          Overflow.hidden
          Label' "_paginated" ]

let height_as_viewport =
    fss [ Height' screen_height
          Label' "_height_as_viewport" ]

let height_filled =
    fss [ Height' fill_height
          Label' "_height_filled" ]

let minHeight_as_viewport =
    fss [ MinHeight' screen_height
          Label' "_minHeight_as_viewport" ]

let centered_container =
    fss [ Display.flex
          JustifyContent.center
          AlignItems.center
          Height' fill_height
          Label' "_centered_container" ]

let flex_hor_container_center =
    fss [ Display.flex
          JustifyContent.center
          AlignItems.center
          Label' "_flex_hor_container_center" ]

let flex_hor_container_start =
    fss [ Display.flex
          JustifyContent.flexStart
          AlignItems.center
          Label' "_flex_hor_container_start" ]

let flex_ver_container_center =
    fss [ Display.flex
          FlexDirection.column
          JustifyContent.center
          AlignItems.center
          Label' "_flex_ver_container_center" ]

let flex_ver_container_start =
    fss [ Display.flex
          FlexDirection.column
          JustifyContent.flexStart
          AlignItems.center
          Label' "_flex_ver_container_start" ]

let alignItems_stretch =
    fss [ AlignItems.stretch
          Label' "_alignItems_stretch" ]

let alignItems_start =
    fss [ AlignItems.flexStart
          Label' "_alignItems_start" ]

let justifyContent_center =
    fss [ JustifyContent.center
          Label' "_justifyContent_center" ]

let flex_none =
    fss [ FlexGrow'(CssFloat 0.0)
          FlexShrink'(CssFloat 0.0)
          FlexBasis.auto
          Label' "_flex_none" ]

let flex_auto =
    fss [ FlexGrow'(CssFloat 1.0)
          FlexShrink'(CssFloat 1.0)
          FlexBasis.auto
          Label' "_flex_auto" ]

let padding_base =
    fss [ Padding' padding_base'
          Label' "_padding_base" ]

let marging_base_left =
    fss [ MarginLeft' margin_base'
          Label' "_marging_base_left" ]

let margin_base_top =
    fss [ MarginTop' margin_base'
          Label' "_margin_base_top" ]

let margin_big_left =
    fss [ MarginLeft' margin_big'
          Label' "_margin_big_left" ]

let margin_big_top =
    fss [ MarginTop' margin_big'
          Label' "_margin_big_top" ]

let textAlign_center =
    fss [ TextAlign.center
          Label' "_textAlign_center" ]

// base classes
let ul_hor = fss [ Display.flex; Label' "_ul_hor" ]

let ul_ver =
    fss [ Display.flex
          FlexDirection.column
          Label' "_ul_ver" ]

let a_button =
    fss [ PaddingLeft' padding_button_hor
          PaddingRight' padding_button_hor
          PaddingTop' padding_button_ver
          PaddingBottom' padding_button_ver
          Cursor.pointer
          Hover [ Color' panel_foreground_color_hovered ]
          Label' "_a_button" ]

let a_button_selected =
    fss [ Color' accent_color
          Label' "_a_button_selected" ]

let icon_social =
    fss [ Width' social_icon_size
          Height' social_icon_size
          Cursor.pointer
          Padding' padding_social_icon
          Label' "_icon_social" ]

let portrait =
    fss [ Width'(rem 12.0)
          Height'(rem 12.0)
          MarginBottom'(px 6)
          Label' "_portrait" ]

let portrait_card =
    fss [ BorderWidth'(px 1)
          BorderStyle.solid
          BorderColor' page_separator_color
          BorderRadius' (px 5)
          PaddingLeft' padding_portrait_card_hor
          PaddingRight' padding_portrait_card_hor
          PaddingTop' padding_portrait_card_ver
          PaddingBottom' padding_portrait_card_ver
          Overflow.hidden
          MinWidth' (rem 13.)
          MinHeight' (rem 18.)
          Label' "_portrait_card"]

let separator_hor =
    fss [ Height'(px 1)
          BorderBottomWidth'(px 1)
          BorderBottomStyle.solid
          BorderBottomColor' page_separator_color
          Width' fill_width
          Label' "_separator_hor" ]
