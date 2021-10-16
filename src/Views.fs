[<RequireQualifiedAccess>]
module Views

open Fable.React
open Fable.React.Props

open App.Domain
open App.utilities

let siteTitle = "F.Rossi"
Browser.Dom.document.title <- siteTitle

let pages = [ "About", Some Page.About
              "Projects", None
              "Blog", None
              "Contact", None ]

let headerView (model: Model) (dispatch: Msg -> unit) =
    header [ classes [ Styles.panel_theme
                       Styles.flex_none
                       Styles.padding_base ] ] [
        div [ classes [ Styles.paginated
                        Styles.flex_hor_container_start ] ] [
            a [ classes [ Styles.a_button
                          Styles.home_button ]
                OnClick(fun _ -> dispatch (SwitchPage Page.Home))
            ] [
                str siteTitle
            ]
            ul [ classes [ Styles.ul_hor
                           Styles.margin_big_left ] ] [

                for title, page' in pages do
                    match page' with
                    | Some page ->
                        li [ classes [ Styles.li_hor
                                       Styles.header_button_hover_transitions ] ] [
                            a [ classes [ Styles.a_button
                                          if model.CurrentPage = page then
                                              Styles.a_button_selected ]
                                if model.CurrentPage <> page then
                                    OnClick(fun _ -> dispatch (SwitchPage page)) ] [
                                str title
                            ]
                        ]
                    | None ->
                        li [ classes [ Styles.li_hor
                                       Styles.header_button_hover_transitions ] ] [
                            a [ Class Styles.a_button ] [
                                str title
                            ]
                        ]
            ]
        ]
    ]

let footerView (model: Model) (dispatch: Msg -> unit) =
    footer [ classes [ Styles.panel_theme
                       Styles.flex_none
                       Styles.textAlign_center
                       Styles.padding_base ] ] [
        div [ classes [ Styles.paginated ] ] [
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
        div [ classes [ Styles.flex_ver_container_start
                        Styles.alignItems_stretch
                        Styles.minHeight_as_viewport ] ] [
            headerView model dispatch
            div [ classes [ Styles.paginated
                            Styles.flex_auto ] ] [
                content
            ]
            footerView model dispatch
        ]
    ]

let homeView (model: Model) (dispatch: Msg -> unit) card =
    div [ classes [ Styles.page_theme
                    Styles.height_as_viewport ] ] [
        div [ classes [ Styles.paginated
                        Styles.centered_container ] ] [
            div [ Class Styles.flex_hor_container_center ] [
                card
                <| ul [ classes [ Styles.ul_ver
                                  Styles.alignItems_start ] ] [
                    for title, page' in pages do
                        match page' with
                        | Some page ->
                            li [ classes [ Styles.li_ver
                                           Styles.home_button_hover_transitions ] ] [
                                a [ classes [ Styles.a_button ]
                                    OnClick(fun _ -> dispatch (SwitchPage page)) ] [
                                    str title
                                ]
                            ]

                        | None ->
                            li [ classes [ Styles.li_ver
                                           Styles.home_button_hover_transitions ] ] [
                                a [ classes [ Styles.a_button
                                              ] ] [
                                    str title
                                ]
                            ]
                   ]
            ]
        ]
    ]
