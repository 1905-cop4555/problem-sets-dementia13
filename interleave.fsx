let xs = [1; 2; 3]
let ys = [11; 21; 31]

let rec interleave = function
    | xs, []  -> xs
    | [], ys  -> ys
    | x::xs, y::ys -> x::y::interleave (xs, ys)

//interleave (xs, ys)
//interleave ([], ys)
interleave (xs, [])