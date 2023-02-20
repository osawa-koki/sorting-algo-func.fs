
module Display

let Display (title: string) (arr: int []) =
  let paddedTitle = title.PadRight(20)
  printfn "%s: %s" paddedTitle (String.concat " " (Array.map string arr))
