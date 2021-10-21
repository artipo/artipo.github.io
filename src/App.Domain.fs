module App.Domain

[<RequireQualifiedAccess>]
type Page =
    | Home
    | About
    | Projects

type Model =
    { Home: Home.Model
      About: About.Model
      Projects: Projects.Model
      CurrentPage: Page }

type Msg =
    | HomeMsg of Home.Msg
    | AboutMsg of About.Msg
    | ProjectsMsg of Projects.Msg
    | SwitchPage of Page

let init () : Model =
    { Home = Home.init ()
      About = About.init ()
      Projects = Projects.init ()
      CurrentPage = Page.Home }
