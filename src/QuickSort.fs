
module QuickSort

let QuickSort (arr: int []) =
  let rec Sort (arr: int []) =
    if Array.length arr <= 1 then arr
    else
      let pivot = arr.[0]
      let left = Array.filter (fun x -> x < pivot) arr
      let right = Array.filter (fun x -> x > pivot) arr
      Array.append (Array.append (Sort left) [|pivot|]) (Sort right)
  Sort arr
