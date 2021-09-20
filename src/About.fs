[<RequireQualifiedAccess>]
module About

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props

// MODEL
type Model = { a: int }

type Msg = | None

let init () = { Model.a = 0 }

let update (msg: Msg) (model: Model): Model =
    model

let view (model: Model) (dispatch: Msg -> unit) =
    div [] [
        h3 [] [ str "My life in coding" ]
        p [] [ str "Hi, I'm a backend web developer based in Italy." ]
        // br []
        p [] [ str "I dwell in the .Net stack. After having mastered C# for 3+ years I'm slowly moving to F#." ]
        p [] [ str "My love for clear and maintenable code reflects in the various projects I've worked on." ]
    ]