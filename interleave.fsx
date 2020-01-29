let xs = [1; 2; 3]
let ys = [11; 21; 31]

let rec interleave (a, b) = function
    | _, []  -> []
    | x::xs, [] -> x::xs
    | [], y::ys -> y::ys
    | x::xs, y::ys -> let tail = interleave (xs, ys)
            let middle = y::tail
            x::middle

interleave (xs, ys)