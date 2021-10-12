[<RequireQualifiedAccess>]
module Views

open Fable.React
open Fable.React.Props

open App.Domain
open App.utilities

let siteTitle = "Federico Rossi"

let headerView (model: Model) (dispatch: Msg -> unit) =
    header [ classes [ Styles.panel_theme
                       Styles.flex_none
                       Styles.flex_hor_container_start
                       Styles.padding_base ] ] [
        h3 [] [ str "My Site |> F#" ]
        ul [ classes [ Styles.ul_hor
                       Styles.margin_big_left ] ] [

            for title, page' in
                [ "Card", Some Page.Home
                  "Inspect", Some Page.About
                  "Tales", None
                  "Opinions", None
                  "Contact", None ] do

                match page' with
                | Some page ->
                    a [ classes [ Styles.a_button
                                  if model.CurrentPage = page then
                                      Styles.a_button_selected ]
                        OnClick(fun _ -> dispatch (SwitchPage page)) ] [
                        str title
                    ]
                | None ->
                    a [ Class Styles.a_button ] [
                        str title
                    ]
        ]
    ]

let footerView (model: Model) (dispatch: Msg -> unit) =
    footer [ classes [ Styles.panel_theme
                       Styles.flex_none
                       Styles.textAlign_center
                       Styles.padding_base ] ] [
        div [] [
            str "Social"
            ul [ classes [ Styles.ul_hor
                           Styles.justifyContent_center ] ] [
                for link, icon in
                    [ "https://github.com/artipo", "./imgs/Icons/github_logo_icon.png"
                      "https://www.linkedin.com/in/federico-rossi-b589701a2/", "./imgs/Icons/linkedin_logo_icon.png"
                      "https://stackoverflow.com/users/12730306/federico-rossi", "./imgs/Icons/stackoverflow_logo_icon.png" ] do
                    li [] [
                        a [ Href link ] [
                            img [ Class Styles.icon_social
                                  Src icon ]
                        ]
                    ]
            ]
        ]
    ]

let baseView (model: Model) (dispatch: Msg -> unit) content =
    div [ Class Styles.page_theme ] [
        div [ classes [ Styles.paginated
                        Styles.flex_ver_container_start
                        Styles.alignItems_stretch
                        Styles.minHeight_as_viewport ] ] [
            headerView model dispatch
            div [ classes [ Styles.flex_auto
                            Styles.padding_base ] ] [
                content
            ]
            footerView model dispatch
        ]
    ]

let homeView (model: Model) (dispatch: Msg -> unit) content =
    div [ classes [ Styles.page_theme
                    Styles.height_as_viewport ] ] [
        div [ classes [ Styles.paginated
                        Styles.centered_container ] ] [
            div [ Class Styles.flex_hor_container_center ] [
                content

                div [ classes [ Styles.flex_ver_container_center
                                Styles.margin_big_left ] ] [
                    h3 [] [ str "Actions" ]
                    ul [ Class Styles.ul_ver ] [

                        for title, page' in
                            [ "Inspect", Some Page.About
                              "Tales", None
                              "Opinions", None
                              "Contact", None ] do

                            match page' with
                            | Some page ->
                                a [ classes [ Styles.a_button
                                              if model.CurrentPage = page then
                                                  Styles.a_button_selected ]
                                    OnClick(fun _ -> dispatch (SwitchPage page)) ] [
                                    str title
                                ]
                            | None ->
                                a [ Class Styles.a_button ] [
                                    str title
                                ]
                    ]
                ]
            ]
        ]
    ]
