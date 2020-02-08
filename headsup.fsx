let heads = [[0;2;4];[6;8];[10]]

let rec headsup = function
    | [] -> []
    | x::xs -> (x + 1)::List.map List.head headsup xs
headsup(heads)