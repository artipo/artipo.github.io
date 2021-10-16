[<RequireQualifiedAccess>]
module Home

open Fable.React
open Fable.React.Props

open App.utilities

// MODEL
type Model = { a: int }

type Msg = | None

let init () = { Model.a = 0 }

let update (msg: Msg) (model: Model) : Model = model

let view (model: Model) (dispatch: Msg -> unit) (actions: ReactElement) =
    div [ classes [ Styles.portrait_card
                    Styles.flex_ver_container_start
                    Styles.alignItems_start ] ] [
        img [ Class Styles.portrait
              Src "./imgs/my_icon.png" ]
        
        div [ Class Styles.separator_hor ] []
        
        div [ Class Styles.portrait_section ] [
            p [] [ str "Federico Rossi" ]
            p [] [ str "Desktop / Backend developer" ]
        ]
        
        div [ Class Styles.separator_hor ] []
        
        div [ Class Styles.portrait_section ] [
            actions
        ]
    ]
