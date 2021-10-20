module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Elmish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props

open App.Domain

// UPDATE
let update (msg: Msg) (model: Model) : Model =
    match msg with
    | HomeMsg homeMsg ->
        let updateHome = Home.update homeMsg model.Home
        { model with Home = updateHome }
    
    | AboutMsg aboutMsg ->
        let updateAbout = About.update aboutMsg model.About
        { model with About = updateAbout }
    
    | ProjectsMsg projectsMsg ->
        let updateProjects = Projects.update projectsMsg model.Projects
        { model with Projects = updateProjects }
    
    | BlogMsg blogMsg ->
        let updateBlog = Blog.update blogMsg model.Blog
        { model with Blog = updateBlog }
    
    | ContactsMsg contactsMsg ->
        let updateContacts = Contacts.update contactsMsg model.Contacts
        { model with Contacts = updateContacts }

    | SwitchPage page -> { model with CurrentPage = page }

// VIEW (rendered with React)
let view (model: Model) (dispatch: Msg -> unit) =

    match model.CurrentPage with
        | Page.Home ->
            Home.view model.Home (HomeMsg >> dispatch)
            |> Views.homeView model dispatch
        | Page.About ->
            About.view model.About (AboutMsg >> dispatch)
            |> Views.baseView model dispatch
        | Page.Projects ->
            Projects.view model.Projects (ProjectsMsg >> dispatch)
            |> Views.baseView model dispatch
        | Page.Blog ->
            Blog.view model.Blog (BlogMsg >> dispatch)
            |> Views.baseView model dispatch
        | Page.Contacts ->
            Contacts.view model.Contacts (ContactsMsg >> dispatch)
            |> Views.baseView model dispatch
        

// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
