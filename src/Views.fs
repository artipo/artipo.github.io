[<RequireQualifiedAccess>]
module Views

open Fable.React
open Fable.React.Props

open App.Domain

let siteTitle = "Federico Rossi"

let headerView (model: Model) (dispatch: Msg -> unit) =
    header [ Class "header to_the_left" ] [
        h3 [] [ str "My Site |> F#" ]
        ul [ Class "list" ] [
            li [] [
                a [ OnClick(fun _ -> dispatch (SwitchPage Page.Home)) ] [
                    str "Card"
                ]
            ]

            li [] [
                a [ if model.CurrentPage = Page.About then
                        Class "selected"
                    else
                        OnClick(fun _ -> dispatch (SwitchPage Page.About)) ] [
                    str "Inspect"
                ]
            ]

            li [] [ a [] [ str "Tales" ] ]

            li [] [ a [] [ str "Opinions" ] ]

            li [] [ a [] [ str "Contact" ] ]
        ]
    ]

let footerView (model: Model) (dispatch: Msg -> unit) =
    footer [ Class "footer" ] [
        div [] [
            str "Social"
            ul [ Class "list" ] [
                li [] [
                    a [ Href "https://github.com/artipo" ] [
                        img [ Class "social_icon"; Src "./imgs/Icons/github_logo_icon.png" ]
                    ]
                ]

                li [] [
                    a [ Href "https://www.linkedin.com/in/federico-rossi-b589701a2/" ] [
                        img [ Class "social_icon"; Src "./imgs/Icons/linkedin_logo_icon.png" ]
                    ]
                ]

                li [] [
                    a [ Href "https://stackoverflow.com/users/12730306/federico-rossi" ] [
                        img [ Class "social_icon"; Src "./imgs/Icons/stackoverflow_logo_icon.png" ]
                    ]
                ]
            ]
        ]
    ]

let baseView (model: Model) (dispatch: Msg -> unit) content =
    div [ Class "container min_size_to_screen base-container" ] [
        headerView model dispatch
        div [ Class "content" ] [ content ]
        footerView model dispatch
    ]

let homeView (model: Model) (dispatch: Msg -> unit) content =
    div [ Class "container size_to_screen" ] [
        div [ Class "centered" ] [
            div [ Class "h-flexer" ] [
                content

                div [ Class "actions" ] [
                    h3 [] [ str "Actions" ]
                    ul [ Class "list" ] [
                        li [] [
                            a [ OnClick(fun _ -> dispatch (SwitchPage Page.About)) ] [
                                str "Inspect"
                            ]
                        ]

                        li [] [ a [] [ str "Tales" ] ]

                        li [] [ a [] [ str "Opinions" ] ]

                        li [] [ a [] [ str "Contact" ] ]
                    ]
                ]
            ]
        ]
    ]
