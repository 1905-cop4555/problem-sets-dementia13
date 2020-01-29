let lx = [1; 2; 3]
let ly = [21; 22; 32]
let list2 = lx @ ly
let list3 = List.head lx :: ly
let list4 = List.head lx :: List.tail lx @ List.head ly :: List.tail ly 
let list5 = List.tail lx @ List.tail ly
let list6 = list3 @ list4
let list7 = List.head lx :: list3 @ List.head ly::list4
let li1 = List.head lx
let li2 = List.head ly
let list8 = (List.head lx, List.head ly)
//let list9 = List.map (List.head list8)::[] list8
let rec prlist ly = function
    | [] -> []
    | l::ly -> printfn "%A" (prlist ly)