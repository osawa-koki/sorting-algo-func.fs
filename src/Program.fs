
open Display
open Shuffle
open BubbleSort
open SelectionSort
open InsertionSort
open QuickSort

[<EntryPoint>]
let main argv = 

  let arr = [|0..9|]
  Display "Original" arr

  Display "Shuffled" (ShuffleArray arr)

  Display "Bubble Sorted" (BubbleSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Selection Sort" (SelectionSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Insertion Sort" (InsertionSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Quick Sort" (QuickSort arr)

  0
