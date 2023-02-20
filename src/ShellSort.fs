
module ShellSort

let ShellSort (arr: int[]) =
  let mutable gap = arr.Length / 2

  while gap > 0 do
    for i = gap to arr.Length - 1 do
      let temp = arr.[i]
      let mutable j = i

      while j >= gap && arr.[j-gap] > temp do
        arr.[j] <- arr.[j-gap]
        j <- j - gap

      arr.[j] <- temp

    gap <- gap / 2

  arr
