
module MergeSort

let rec MergeSort (arr: int []) =
  if Array.length arr <= 1 then arr
  else
    let left = arr.[0..arr.Length/2 - 1] |> MergeSort
    let right = arr.[arr.Length/2..] |> MergeSort
    Merge left right

and Merge (left: int []) (right: int []) =
  let mutable result = [||]
  let mutable i = 0
  let mutable j = 0
  while i < left.Length && j < right.Length do
    if left.[i] < right.[j] then
      result <- Array.append result [|left.[i]|]
      i <- i + 1
    else
      result <- Array.append result [|right.[j]|]
      j <- j + 1
  while i < left.Length do
    result <- Array.append result [|left.[i]|]
    i <- i + 1
  while j < right.Length do
    result <- Array.append result [|right.[j]|]
    j <- j + 1
  result
