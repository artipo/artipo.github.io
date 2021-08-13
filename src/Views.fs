module App.Views

open Fable.React
open Fable.React.Props

let header =
    nav [ Id "main-nav" ] [
        div [ Class "container" ] [
            h1 [] [ str "My Site |> F#" ]
            ul [] [
                li [] [ str "Home" ]
                li [] [ str "About" ]
            ]
        ]
    ]

let baseView content =
    div [] [
        header
        content
    ]