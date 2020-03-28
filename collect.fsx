let rec collect f = function
    | [] -> []
    | x::xs -> let partial = collect f xs
               let current = f x
               current::partial