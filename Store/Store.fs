module Store

open Suave
open Suave.Successful

[<EntryPoint>]
let main argv =
    startWebServer defaultConfig (OK "La figa della Giacotti!!!!")
    0 // return an integer exit code
