// Increase knowledge about functions

let add a b = a + b
let addAndMultiply a b c =
    let sum = a + b
    let product = sum * c
    product

let concat a b = a + b

let convert (a:string):int = int a

let CardFace (card:int):string =
    let no = card % 13
    if no = 1 then "Ace"
    elif no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

let add2 a = a + 2
let multiply3 a = a * 3
let addAndMultiply2 = add2 >> multiply3

let list = [4; 3; 1; 5; 9; 8; 13; 14; 16; 31; 25; 99; 2]
let sort (list: int list) = List.sort list
let print (list: int list) = List.iter(fun x-> printfn "item %i" x) list
list |> sort |> print

// Output test
printfn "%d" (add 2 5)
printfn "%d" (addAndMultiply 2 8 5)
printfn "%s" (concat "hello" " world!")
printfn "%d" ((convert "12") + 3)
printfn "%s" (CardFace 11)
printfn "%d" (addAndMultiply2 2)