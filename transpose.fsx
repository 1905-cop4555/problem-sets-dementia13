let list1 = [1; 2; 3]
let list2 = [4; 5; 6]

let rec transpose = function
    | _, [] -> []
//    | x::xs, [] -> []
//    | [], y::ys -> []
    | x::xs, y::ys -> let partial =  transpose(xs, ys)
                      x::y::[]@partial

transpose (list1, list2)