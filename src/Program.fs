
open Display
open Shuffle
open BubbleSort
open SelectionSort

[<EntryPoint>]
let main argv = 

  let arr = [|1..10|]
  Display "Original" arr

  Display "Shuffled" (ShuffleArray arr)

  Display "Bubble Sorted" (BubbleSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Selection Sort" (SelectionSort arr)

  0
