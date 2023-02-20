
module BucketSort

let BucketSort (arr: int[]) =
  let numBuckets = 10
  let mutable buckets = Array.create numBuckets []

  // 各要素を適切なバケットに挿入
  for i = 0 to arr.Length - 1 do
    let bucketIndex = arr.[i] / numBuckets
    buckets.[bucketIndex] <- arr.[i]::buckets.[bucketIndex]

  // 各バケットを単独でソートして、ソート済みバケットを連結
  let mutable sortedArr = [||]
  for i = 0 to numBuckets - 1 do
    let bucket = buckets.[i] |> List.rev |> List.toArray |> Array.sort
    sortedArr <- Array.append sortedArr bucket

  sortedArr
