module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Elmish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props

open App.Views

// MODEL

type Model = int

type Msg =
    | Increment
    | Decrement

let init () : Model = 0

// UPDATE

let update (msg: Msg) (model: Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered with React)

let view (model: Model) dispatch =

    div [ Id "main-content"; Class "container" ] [
        h2 [] [ str "Welcome!" ]
        div [] [
            button [ Class "btn"; OnClick(fun _ -> dispatch Increment) ] [
                str "+"
            ]
            div [] [
                h3 [] [ str (string model) ]
            ]
            button [ Class "btn"; OnClick(fun _ -> dispatch Decrement) ] [
                str "-"
            ]
        ]
    ]
    |> baseView

// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
