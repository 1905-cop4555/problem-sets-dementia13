let hsx = [[1; 2]; [3]; [4; 5; 6]]

let rec explode = function
    | [] -> []
    | x::xs -> explode(xs)
               let rec mush = function
                | [] -> []
                | xs -> List.head xs