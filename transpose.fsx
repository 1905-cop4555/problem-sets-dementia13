//open System.Runtime.Remoting.Metadata.W3cXsd2001

let list1 = [1; 2; 3]
let list2 = [4; 5; 6]
//let list3 = [list1; list2]

let rec explode thelist = function
    | [] -> []
    | x::xs -> x::[]@xs

let rec transpose (explode xs, explode ys) = function        // Creates a single list
    | x::xs, [] -> [x]@[]
    | [], y::ys -> [y]@[]
    | x::xs, y::ys -> [x::[]; y::[]]@transpose(xs, ys)
 //                     [[x];[y]]@mush
 //                     mush
//    | x::xs, y::ys -> [x::[]@xs; [y]@ys]@[]

transpose (list1, list2)

let rec transpose2 = function       // Creates a list of lists
    | [] -> []
    | x::xs -> let partial = transpose2(List.map List.tail xs)
               let current = List.map List.head xs
               current::partial

//transpose2 list3