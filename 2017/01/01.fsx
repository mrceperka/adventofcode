module ``01``

let predicate i value arr arrLen = value = (Array.get arr ((i + 1) % arrLen))

let f01 (arr : array<int>) = 
    let arrLen = arr.Length
    arr
    |> Array.indexed
    |> Array.filter (fun (i, value) -> predicate i value arr arrLen)
    |> Array.map snd
    |> Array.sum

let f02 (arr : array<int>) = 
    let arrLen = arr.Length
    arr
    |> Array.indexed
    |> Array.sumBy (fun (i, value) -> 
           if predicate i value arr arrLen then value
           else 0)

printf "%A\n" (f01 [| 1; 2; 2; 1 |])
printf "%A\n\n" (f02 [| 1; 2; 2; 1 |])

printf "%A\n" (f01 [| 1; 1; 1; 1 |])
printf "%A\n\n" (f02 [| 1; 1; 1; 1 |])

printf "%A\n" (f01 [| 1; 2; 3; 4 |])
printf "%A\n\n" (f02 [| 1; 2; 3; 4 |])
 
printf "%A\n" (f01 [| 9; 1; 2; 1; 2; 1; 2; 9 |])
printf "%A\n\n" (f02 [| 9; 1; 2; 1; 2; 1; 2; 9 |])
