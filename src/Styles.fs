[<RequireQualifiedAccess>]
module Styles

open Fss
open Fss.FssTypes

open App.utilities
open Fss.Utilities

// colors
let page_background_color = rgb 238 238 238
let page_foreground_color = rgb 51 51 51
let page_separator_color = rgb 153 153 153
let page_portrait_background_color = rgb 245 245 245
let page_portrait_shadow_color = rgb 211 211 211
let panel_background_color = rgb 221 221 221
let panel_foreground_color = rgb 51 51 51
let panel_foreground_color_hovered = rgb 125 125 125
let accent_color = rgb 238 134 64
let accent_foreground_color = rgb 51 51 51

// sizes
let private page_width = px 1100
let private screen_width = vw 100.0
let private screen_height = vh 100.0
let private fill_width = pct 100
let private fill_height = fill_width
let private social_icon_size = rem 2.

// paddings
let private padding_base' = rem 1.
let private padding_button_hor = rem 0.5
let private padding_button_ver = rem 0.3
let private padding_social_icon = rem 0.5
let private padding_portrait = rem 1.5
let private padding_portrait_card_hor = rem 1.
let private padding_portrait_card_ver = rem 1.5
let private padding_portrait_section = rem 1.

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
          Width' screen_width
          Label' "_panel_theme" ]

let paginated =
    fss [ Width' fill_width
          MaxWidth' page_width
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

let padding_button =
    fss
    <| [ Label' "_padding_button" ]
        @ padding_2 padding_button_hor padding_button_ver

let padding_none_left =
    fss [ PaddingLeft' (px 0)
          Label' "_padding_none_left" ]

let margin_auto =
    fss [ Margin.auto
          Label' "_margin_auto" ]

let marging_base_left =
    fss [ MarginLeft' margin_base'
          Label' "_marging_base_left" ]

let margin_base_top =
    fss [ MarginTop' margin_base'
          Label' "_margin_base_top" ]

let margin_base_bottom =
    fss [ MarginBottom' margin_base'
          Label' "_margin_base_bottom" ]

let margin_big_left =
    fss [ MarginLeft' margin_big'
          Label' "_margin_big_left" ]

let margin_big_top =
    fss [ MarginTop' margin_big'
          Label' "_margin_big_top" ]

let textAlign_center =
    fss [ TextAlign.center
          Label' "_textAlign_center" ]
    
let textAlign_start =
    fss [ TextAlign.start
          Label' "_textAlign_start" ]

// base classes
let ul_hor = fss [ Display.flex; Label' "_ul_hor" ]

let ul_ver =
    fss [ Display.flex
          FlexDirection.column
          Label' "_ul_ver" ]

let a_button =
    fss
    <| [ TextAlign.center
         Cursor.pointer
         Label' "_a_button" ]

let a_button_selected =
    fss [ Color' accent_color
          Label' "_a_button_selected" ]

let home_button_hover_transitions =
    fss [ TransitionProperty.values [ Property.Transform; Property.Color ]
          TransitionDuration' (sec 0.35)
          Hover [ Transforms [ Transform.translateX (px 10) ]
                  Color' accent_color ]
          Label' "_home_button_hover_transitions" ]

let header_button_hover_transitions =
    fss [ TransitionProperty.values [ Property.Color ]
          TransitionDuration' (sec 0.35)
          Hover [ Color' accent_color ]
          Label' "_header_button_hover_transitions" ]

let home_button =
    fss [ FontWeight.bold
          FontSize.larger
          Label' "_home_button"]

let li_ver =
    fss
    <| [ Label' "_li_ver" ]
        @ margin_ver_1 padding_button_ver

let li_hor =
    fss
    <| [ Label' "_li_hor" ]
        @ margin_hor_1 padding_button_hor

let with_arrow =
    fss [ BackgroundImage.url "./imgs/Icons/arrow_turn_icon.png"
          BackgroundPosition.values (Background.Position.Left, pct 75)
          BackgroundRepeat.noRepeat
          BackgroundSize' (px 20)
          PaddingLeft' (px 25)
          Label' "_with_arrow" ]

let icon_social =
    fss
    <| [ Width' social_icon_size
         Height' social_icon_size
         Cursor.pointer
         Label' "_icon_social" ]
        @ margin_hor_1 padding_social_icon

let portrait =
    fss
    <| [ Width'(rem 12.0)
         Height'(rem 12.0)
         Margin.auto
         Label' "_portrait" ]
        @ padding_1 padding_portrait

let portrait_card =
    fss
    <| [ BackgroundColor' page_portrait_background_color
         BoxShadows [ BoxShadow.blurColor (px 0, px 0, em 1., page_portrait_shadow_color) ]
         Overflow.hidden
         MinWidth'(rem 19.0)
         MinHeight'(rem 18.0)
         MaxWidth'(rem 20.0)
         MaxHeight'(rem 40.0)
         Label' "_portrait_card" ]
        @ border_solid_3 (px 1) page_separator_color (px 5)
        @ padding_2 padding_portrait_card_hor padding_portrait_card_ver

let portrait_section =
    fss
    <| [ Label' "_portrait_section" ]
        @ padding_1 padding_portrait_section

let pipe_op =
    fss [ Color' Color.mediumSeaGreen
//          FontWeight.bold
          Label' "_pipe_op" ]

let love_op =
    fss [ Color' Color.indianRed
//          FontWeight.bold
          Label' "_love_op" ]

let separator_hor =
    fss [ Height'(px 1)
          BorderBottomWidth'(px 1)
          BorderBottomStyle.solid
          BorderBottomColor' page_separator_color
          Width' fill_width
          Label' "_separator_hor" ]
