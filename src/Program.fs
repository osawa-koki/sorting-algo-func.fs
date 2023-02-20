
open Display
open Shuffle
open BubbleSort
open SelectionSort
open InsertionSort

[<EntryPoint>]
let main argv = 

  let arr = [|1..10|]
  Display "Original" arr

  Display "Shuffled" (ShuffleArray arr)

  Display "Bubble Sorted" (BubbleSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Selection Sort" (SelectionSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Insertion Sort" (InsertionSort arr)

  0
