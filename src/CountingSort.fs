
module CountingSort

let CountingSort (arr: int[]) =
  let mutable countArr = Array.zeroCreate (Array.max arr + 1)
  let mutable sortedArr = Array.zeroCreate arr.Length

  // カウント配列を作成
  for i in arr do
    countArr.[i] <- countArr.[i] + 1

  // カウント配列を累積和配列に変換
  for i = 1 to Array.length countArr - 1 do
    countArr.[i] <- countArr.[i] + countArr.[i-1]

  // ソートされた配列を作成
  for i = Array.length arr - 1 downto 0 do
    let j = arr.[i]
    sortedArr.[countArr.[j]-1] <- j
    countArr.[j] <- countArr.[j] - 1

  sortedArr
