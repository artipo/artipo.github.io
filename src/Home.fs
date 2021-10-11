[<RequireQualifiedAccess>]
module Home

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
    div [ Class "char-card" ] [
        img [ Styles.myIcon; Src "./imgs/my_icon.png" ]
        div [ Class "hsep" ] []
        p [] [ str "Federico Rossi" ]
        div [ Class "hsep" ] []
        p [] [ str "01/02/1994" ]
    ]