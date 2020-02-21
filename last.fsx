//let rec last = function
//    | []  -> failwith "empty list has no last element"
//    | [x] -> x
//    | x::xs -> last xs

let xs = [1; 3; 5]

let rec last xs =
    if List.tail xs = [] then List.head xs else last (List.tail xs)

last (xs)

