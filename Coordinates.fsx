open System

type 'a coordinates =
    | Tuple of val1: 'a * val2: 'a
    | Threeple of val1: 'a * val2: 'a * val3: 'a
    | Fourple of val1: 'a * val2: 'a * val3: 'a * val4: 'a

let theints = Tuple(4 , 20) // :)
let thefloats = Threeple(3.2, 151.0, 97.8)
let thestrings = Fourple("Farcical aquatic ceremony", "Judean People's Front", "Scott of the Antarctic", "Grale frit")

//let munch = (+)

let functiondelic munch coordinates = 
    match coordinates with
    | Tuple(x, y) -> munch x y
    | Threeple(x, y, z) -> munch x (munch y z)
    | Fourple(w, x, y, z) -> munch w (munch x (munch y z))

printfn "%A" (functiondelic (+) theints )
printfn "%A" (functiondelic (-) thefloats)
printfn "%A" (functiondelic (+) thestrings)