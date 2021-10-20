module App.Domain

[<RequireQualifiedAccess>]
type Page =
    | Home
    | About
    | Projects
    | Blog
    | Contacts

type Model =
    { Home: Home.Model
      About: About.Model
      Projects: Projects.Model
      Blog: Blog.Model
      Contacts: Contacts.Model
      CurrentPage: Page }

type Msg =
    | HomeMsg of Home.Msg
    | AboutMsg of About.Msg
    | ProjectsMsg of Projects.Msg
    | BlogMsg of Blog.Msg
    | ContactsMsg of Contacts.Msg
    | SwitchPage of Page

let init () : Model =
    { Home = Home.init ()
      About = About.init ()
      Projects = Projects.init ()
      Blog = Blog.init ()
      Contacts = Contacts.init ()
      CurrentPage = Page.Home }
