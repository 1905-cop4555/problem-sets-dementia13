let curry f x y = f(x) y
let uncurry g (x) y = g x y

let plus = uncurry(+)
let cplus = curry plus 2 
plus 2 3
cplus 4
