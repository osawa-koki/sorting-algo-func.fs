
open Display
open Shuffle
open BubbleSort
open SelectionSort
open InsertionSort
open QuickSort
open MergeSort
open HeapSort
open CountingSort
open ShellSort
open BucketSort

[<EntryPoint>]
let main _ = 

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

  Display "Shuffled" (ShuffleArray arr)

  Display "Merge Sort" (MergeSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Heap Sort" (HeapSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Counting Sort" (CountingSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Shell Sort" (ShellSort arr)

  Display "Shuffled" (ShuffleArray arr)

  Display "Bucket Sort" (BucketSort arr)

  0
