type terminal = IF|THEN|ELSE|BEGIN|END|PRINT|SEMICOLON|ID|EOF

let accept() = "All input read"
let error() = "Early termination or missing EOF"

let test_program program = 
    let result = program |> S
    match result with
    | [] -> failwith "Early termination or missing EOF"
    | x::xs -> if x = EOF then accept() else error()