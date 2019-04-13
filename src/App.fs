module App

open Fable.Helpers.React.Props
open Elmish
open Elmish.React

open App.State

module R = Fable.Helpers.React

let init _ =
    { count = 0 }, []

let update msg model =
    match msg with
        | Incr -> { count = model.count + 1 }, []
        | Decr -> { count = model.count - 1 }, []

let view model dispatch =
    R.div [] [
        R.button
            [ OnClick (fun _ -> dispatch Incr) ]
            [ R.str "+" ]
        R.h2
            []
            [ R.str (string model.count) ]
        R.button
            [ OnClick (fun _ -> dispatch Decr) ]
            [R.str "-"]
    ]

Program.mkProgram init update view
|> Program.withReact "app"
|> Program.run
