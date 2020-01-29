//printf "Hello world!\n"
//printfn "%s" "Hello world!\n"
//let hw = "Hello world!\n"

(* Taking username input and matching against a list of known names *)

let hello = "Hello, "
//printfn "%s" hw
let np = "What's your name?\n"
printfn "%s" np
let name = System.Console.ReadLine()
let validname  =  
    match name with
    | "Alice" -> name
    | "Bob" -> name
    | _ -> "stranger"

printfn "%s%s" hello validname 

(*  *)