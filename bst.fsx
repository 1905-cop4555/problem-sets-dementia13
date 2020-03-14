type 'a tree = Lf | Br of 'a * 'a tree * 'a tree

//let srchtrm = 37
let srchtrm = 42

let left = Br(7, Br(0, Lf, Lf), Br(3, Lf, Br(7, Lf, Lf)))
let right = Br(11, Br(23, Lf, Lf), Br(37, Lf, Lf))

let thetree = (9, left, right)

let rec element n = function
| Lf    -> false
| Br(m, t1, t2) -> if n = m then true
                   elif n < m then element n t1
                   else element n t2

let rec merge t1 t2 =
    match t1, t2 with
    | Lf, Lf -> Lf
    | t1, Lf -> t1
    | Lf, t2 -> t2
    | Br(n, t1, t2), rst -> Br(n, t1, merge t2 rst)

let rec remove n = function
    | Lf -> failwith "Value not present"
    | Br(n, t1, t2) -> if n = srchtrm then merge t1 t2
                       elif n < srchtrm then Br(srchtrm, remove n t1, t2)
                       else Br(srchtrm, t1, remove n t2)