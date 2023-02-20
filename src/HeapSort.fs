
module HeapSort

let rec Heapify(nums: int[], n: int, i: int) =
  let mutable largest = i
  let mutable left = i * 2 + 1
  let mutable right = i * 2 + 2

  // 左の子ノードが最大の場合
  if left < n && nums.[left] > nums.[largest] then
    largest <- left

  // 右の子ノードが最大の場合
  if right < n && nums.[right] > nums.[largest] then
    largest <- right

  // 最大の子ノードが親ノードより大きい場合、交換して再帰呼び出し
  if largest <> i then
    let temp = nums.[i]
    nums.[i] <- nums.[largest]
    nums.[largest] <- temp

    Heapify(nums, n, largest)

let HeapSort(nums: int[]) =
  let mutable n = Array.length nums

  // 最大ヒープを構築
  for i = n / 2 - 1 downto 0 do
    Heapify(nums, n, i)

  // ヒープから要素を1つずつ取り出し、昇順にソート
  for i = n - 1 downto 0 do
    // 最大値を取り出し、配列の末尾と交換
    let temp = nums.[0]
    nums.[0] <- nums.[i]
    nums.[i] <- temp

    // ヒープを再構築
    n <- n - 1
    Heapify(nums, n, 0)

  nums
