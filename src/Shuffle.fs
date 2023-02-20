module Shuffle
open System

let ShuffleArray (arr: int []) =
    let random = Random()
    for i = Array.length arr - 1 downto 1 do
        let j = random.Next(i + 1)
        let temp = arr.[i]
        arr.[i] <- arr.[j]
        arr.[j] <- temp
    arr
