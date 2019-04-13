module App.State
    type Model = {
        count: int
    }

    type Msg =
        | Incr
        | Decr
