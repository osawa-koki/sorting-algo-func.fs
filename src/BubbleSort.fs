
module BubbleSort

let BubbleSort (arr: int []) =
    let mutable isSorted = false
    while not isSorted do
        isSorted <- true
        for i in 0..Array.length arr - 2 do
            if arr.[i] > arr.[i + 1] then
                let temp = arr.[i]
                arr.[i] <- arr.[i + 1]
                arr.[i + 1] <- temp
                isSorted <- false
    arr
