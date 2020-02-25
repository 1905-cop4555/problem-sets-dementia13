let rec appmap f = function
    | [] -> []
    | x::xs -> f x @ appmap f xs

let rec insert x = function
    | [] -> [[x]]
    | y::ys -> (x::y::ys) :: List.map (fun zs -> y::zs) (insert x ys)

insert 4 [1;3;5]

let rec permute = function
    | [] -> [[]]
    | x::xs -> appmap (insert x) (permute xs)


permute [1; 3; 5; 9]