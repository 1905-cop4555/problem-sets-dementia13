let lx = [1; 2; 3]

let rec powerset = function
    | [] -> [[]]
    | x::xs -> let partial = powerset xs
               List.map (fun xs -> x::xs) partial @ partial

powerset lx