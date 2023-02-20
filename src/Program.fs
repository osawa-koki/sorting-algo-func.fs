
open Display
open Shuffle

[<EntryPoint>]
let main argv = 

  let arr = [|1..10|]
  Display "Original" arr

  Display "Shuffled" (ShuffleArray arr)

  Display "Original" arr

  0
