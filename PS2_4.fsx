type tokens = ADD|SUB|MUL|DIV|LPAR|RPAR|ID|EOF

let advance t = List.tail t

let rec e xs = 
    let newlist = t xs
    match List.head newlist with
        |ADD -> advance newlist |> e
        |SUB -> advance newlist |> e
        |_ -> newlist

    and b xs =
        if List.head = xs = RPAR then advance xs else failwith "No close parenthesis"

    and t xs = 
        let newlist = f xs
        match List.head newlist with 
            |MUL