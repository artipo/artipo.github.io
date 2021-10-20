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
    div [ classes [ Styles.card
                    Styles.flex_ver_container_center ] ] [
        div [ classes [ Styles.portrait_section
                        Styles.flex_none ] ] [
            img [ Class Styles.portrait
                  Src "./imgs/my_icon.png" ]
        ]
        
        div [ classes [ Styles.separator_hor
                        Styles.flex_none ] ] []
        
        div [ classes [ Styles.portrait_section
                        Styles.flex_none
                        Styles.alignItems_start ] ] [
            p [] [ str "Federico Rossi" ]
            p [] [ str "Desktop / Backend developer" ]
        ]
        
        div [ classes [ Styles.separator_hor
                        Styles.flex_none ] ] []
        
        div [ classes [ Styles.portrait_section
                        Styles.flex_none
                        Styles.alignItems_start
                        Styles.width_filled ] ] [
            actions
        ]
    ]
