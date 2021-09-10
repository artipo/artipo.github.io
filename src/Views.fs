[<RequireQualifiedAccess>]
module Views

open Fable.React
open Fable.React.Props

open App.Domain

let siteTitle = "Federico Rossi"

let header (model: Model) (dispatch: Msg -> unit) =
    nav [ Id "main-nav" ] [
        div [ Class "header to_the_left" ] [
            h3 [] [ str "My Site |> F#" ]
            ul [ Class "list" ] [
                li [] [
                    a [
                        OnClick (fun _ -> dispatch (SwitchPage Page.Home))
                    ] [
                        str "Card"
                    ]
                ]

                li [] [
                    a [
                        OnClick (fun _ -> dispatch (SwitchPage Page.About))
                    ] [
                        str "Inspect"
                    ]
                ]
            ]
        ]
    ]

let footer (model: Model) (dispatch: Msg -> unit) =
    div [] [ str "footer" ]

let baseView (model: Model) (dispatch: Msg -> unit) content =
    div [Class "container" ] [
        header model dispatch
        content
        footer model dispatch
    ]

let homeView (model: Model) (dispatch: Msg -> unit) content =
    div [ Class "container size_to_screen" ] [
        div [ Class "centered" ] [
            div [ Class "h-flexer" ] [
                content

                div [ Class "actions" ] [
                    h3 [] [
                        str "Actions"
                    ]
                    ul [ Class "list" ] [
                        li [] [
                            a [
                                OnClick (fun _ -> dispatch (SwitchPage Page.About))
                            ] [
                                str "Inspect"
                            ]
                        ]

                        li [] [
                            a [] [
                                str "Tales"
                            ]
                        ]

                        li [] [
                            a [] [
                                str "Opinions"
                            ]
                        ]

                        li [] [
                            a [] [
                                str "Contact"
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
    