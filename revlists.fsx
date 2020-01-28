let xs = [1; 2; 3]
let ys = [11; 21; 31]

let rec interleave = function
    | []    -> []
    | List.map List.head (interleave(List.tail xs))

//let interleave ([]: int list, []: int list) = List.map List.head a @ List.map List.head b
//interleave xs ys
//let aph = List.rev xs 
//let aph = List.tail xs