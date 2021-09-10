module App.Domain

[<RequireQualifiedAccess>]
type Page =
    | Home
    | About
//   | Projects
//   | Contact
//   | Blog Posts

type Model = { Home: Home.Model; About: About.Model; CurrentPage: Page }

type Msg =
    | HomeMsg of Home.Msg
    | AboutMsg of About.Msg
    | SwitchPage of Page

let init () : Model =
    { Home = Home.init ()
      About = About.init()
      CurrentPage = Page.Home }