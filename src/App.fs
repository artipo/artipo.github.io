module App

open Elmish
open Elmish.React

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
        
// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
