let list1 = [1; 2; 3; 4; 5; 6; 7; 8]

let rec gencut = function
    | _, [] -> [], []
    | 1, x::xs -> [x], xs
    | n, x::xs -> let first, second = gencut((n - 1), xs)
                  x::first, second

let cut = gencut((List.length list1) / 2, list1)

let rec interleave = function
    | [], [] -> []
    | xs, [] -> xs
    | [], ys -> ys
    | x::xs, y::ys -> x::y::interleave(xs, ys)

let shuffle xs = interleave(cut)

shuffle list1