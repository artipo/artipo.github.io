module App.utilities

open Fable.React.Props

let classes names =
    names
    |> String.concat " "
    |> Class