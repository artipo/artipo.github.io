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
    str "un sacco di cose diverse, sono un genio, poi mi sveglio!"