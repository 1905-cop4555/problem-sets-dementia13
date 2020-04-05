//------------CURRY/UNCURRY--------------

let curry f  x y = f(x, y)

let uncurry f (x, y) = f x y

let plus (x, y) = x + y

let plus2 = curry plus

printfn "%A" (plus  (3,4))

plus2 (plus(3, 5)) 3

printfn "%A" (plus)

printfn "%A" (plus2)

