[<RequireQualifiedAccess>]
module About

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props

open App.utilities

// MODEL
type Model = { a: int }

type Msg = | None

let init () = { Model.a = 0 }

let update (msg: Msg) (model: Model): Model =
    model

let view (model: Model) (dispatch: Msg -> unit) =
    div [ classes [ Styles.flex_ver_container_start
                    Styles.flex_auto
                    Styles.blogged ] ] [
        div [ classes [ Styles.flex_none
                        Styles.width_filled ] ] [
            h1 [ Class Styles.h_blog_title ] [ str "About" ]
        ]
        
        div [ Class Styles.blog_title_blank_space_hor ] []
        
        div [ classes [ Styles.flex_none ] ] [
            img [ Class Styles.portrait
                  Src "./imgs/my_icon.png" ]
        ]
        
        div [ Class Styles.blog_title_blank_space_hor ] []
        
        div [ classes [ Styles.flex_none ] ] [
            h2 [ Class Styles.h_blog_subtitle ] [ str "Hi! I'm Federico!" ]
            div [ Class Styles.blog_subtitle_blank_space_hor ] []
            p [] [ str "Welcome to my site. My passion about technology brought me to share my knowledge with everyone. Read all my writings in the blog." ]
            
            div [ Class Styles.blog_title_blank_space_hor ] []
            
            h2 [ Class Styles.h_blog_subtitle ] [ str "My interests cover several topics." ]
            div [ Class Styles.blog_subtitle_blank_space_hor ] []
            p [] [ str "Apart from major projects I worked on, I dwell also in game development." ]
            
            div [ Class Styles.blog_title_blank_space_hor ] []
            
            h2 [ Class Styles.h_blog_subtitle ] [ str "I'm still human." ]
            div [ Class Styles.blog_subtitle_blank_space_hor ] []
            p [] [ str "I've got also other hobbies, such as Climbing and Pixel art." ]
        ]
    ]