
module InsertionSort

let InsertionSort (arr: int []) =
  for i in 1..Array.length arr - 1 do
    let j = ref i
    while !j > 0 && arr.[!j - 1] > arr.[!j] do
      let temp = arr.[!j - 1]
      arr.[!j - 1] <- arr.[!j]
      arr.[!j] <- temp
      j := !j - 1
  arr
