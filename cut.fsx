let toobig = [1; 2; 3; 4; 5; 6]

let rec gencut = function
    | _,[] -> [], []
    | 1, x::xs -> [x], xs
    | n, x::xs -> let first, second =  gencut ((n - 1), xs)
                  x::first, second

let cut xs = gencut((List.length xs / 2), xs)

cut toobig