// 1 CURRY/UNCURRY
//let curry f x y = (fun y -> x  y )
let curry f x y = f (x, y)
//let curry f x y = (+)
let uncurry f (x, y) = f x y
let plus = uncurry (+)
plus ("a", "d")
let cplus = curry (plus) 
cplus "a" "d" 

// 2 DISCRIMINATED UNION

type 'a coordinates =
    | Tuple of val1: 'a * val2: 'a
    | Threeple of val1: 'a * val2: 'a * val3: 'a
    | Fourple of val1: 'a * val2: 'a * val3: 'a * val4: 'a

let addn x y = x + y
let chomp (addn, coordinates) =
    match coordinates with
    | Tuple(x, y) -> addn x y
    | Threeple(x, y, z) -> addn x (addn y z)
    | Fourple (x, y, z, p) -> addn x (addn y (addn z p))


let theints = (42, 42)
let thefloats = (5.0, 5.0, 5.0)
let thestrings = ("I repeat myself when in distress ", "I repeat myself when in distress ", "I repeat myself when in distress ", "I repeat myself when in distress ")

//printfn "%A" (chomp  theints)

// 3 SYNTAX CHECKER

type terminal = IF | THEN | ELSE | BEGIN | END | PRINT | SEMICOLON | ID | EOF

