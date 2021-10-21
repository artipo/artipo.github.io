[<RequireQualifiedAccess>]
module Projects

open Fable.React
open Fable.React.Props

open App.utilities

// MODEL
type Model = { a: int }

type Msg = | None

let init () = { Model.a = 0 }

let update (msg: Msg) (model: Model) : Model = model

let view (model: Model) (dispatch: Msg -> unit) =
    div [ classes [ Styles.flex_ver_container_start
                    Styles.flex_auto
                    Styles.blogged ] ] [
        div [ classes [ Styles.flex_none
                        Styles.width_filled ] ] [
            h1 [ Class Styles.h_blog_title ] [ str "Projects" ]
        ]
        
        div [ Class Styles.blog_title_blank_space_hor ] []
        
        div [ classes [ Styles.flex_none
                        Styles.width_filled ] ] [
            h2 [ Class Styles.h_blog_subtitle ] [ str "Alma Italia!" ]
            div [ Class Styles.blog_subtitle_blank_space_hor ] []
            p [] [ str "I worked on S.W. and F. P.L." ]
            
            div [ Class Styles.blog_title_blank_space_hor ] []
            
            h2 [ Class Styles.h_blog_subtitle ] [ str "FutureLab" ]
            div [ Class Styles.blog_subtitle_blank_space_hor ] []
            p [] [ str "I worked on FS." ]
            
            div [ Class Styles.blog_title_blank_space_hor ] []
            
            h2 [ Class Styles.h_blog_subtitle ] [ str "OSS" ]
            div [ Class Styles.blog_subtitle_blank_space_hor ] []
            p [] [ str "MaterialDesignInXamlToolkit" ]
        ]
    ]