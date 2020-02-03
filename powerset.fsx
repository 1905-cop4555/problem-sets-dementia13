let lx = [1; 2; 3]
let rec powerset = function
    | [] -> []
    | x::xs -> let partial = powerset(xs)
                let current = List.map (fun  -> x::xs) partial