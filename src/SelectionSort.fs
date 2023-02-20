
module SelectionSort

let SelectionSort (arr: int []) =
  for i in 0..Array.length arr - 2 do
    let mutable minIndex = i
    for j in i + 1..Array.length arr - 1 do
      if arr.[j] < arr.[minIndex] then
        minIndex <- j
    if minIndex <> i then
      let temp = arr.[i]
      arr.[i] <- arr.[minIndex]
      arr.[minIndex] <- temp
  arr
