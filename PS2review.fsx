let curry f x y = (fun y -> x  y )
let uncurry f (x, y) = f x y
let plus = uncurry (+)
plus ("a", "d")
let cplus = curry 