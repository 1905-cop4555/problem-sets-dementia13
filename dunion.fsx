let rec last = function
    | [x] -> x
    | x::xs -> last xs;;