[<RequireQualifiedAccess>]
module Contacts

open Fable.React

// MODEL
type Model = { a: int }

type Msg = | None

let init () = { Model.a = 0 }

let update (msg: Msg) (model: Model) : Model = model

let view (model: Model) (dispatch: Msg -> unit) =
    div [] [ str "contacts" ]