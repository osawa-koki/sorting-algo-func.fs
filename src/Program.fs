
open Display
open Shuffle
open BubbleSort

[<EntryPoint>]
let main argv = 

  let arr = [|1..10|]
  Display "Original" arr

  Display "Shuffled" (ShuffleArray arr)

  Display "Bubble Sorted" (BubbleSort arr)

  0
