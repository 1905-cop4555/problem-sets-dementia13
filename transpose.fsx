open System.Runtime.Remoting.Metadata.W3cXsd2001

let list1 = [1; 2; 3]
let list2 = [4; 5; 6]
let list3 = [list1; list2]

let rec transpose = function        // Creates a single list
    | _, [] -> []
    | [], _ -> []
//    | x::xs, [] -> []
//    | [], y::ys -> []
    | x::xs, y::ys -> let mush = transpose(xs, ys)
                      x::y::[]@mush
//    | x::xs, y::ys -> List.map 

//transpose (list1, list2)

let rec transpose2 = function       // Creates a list of lists
    | [] -> []
    | x::xs -> let partial = transpose2(List.map List.tail xs)
               let current = List.map List.head xs
               current::partial

transpose2 list3