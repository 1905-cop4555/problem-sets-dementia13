module Interp_script

System.Environment.set_CurrentDirectory __SOURCE_DIRECTORY__;;
#load "parser.fsx"

// This lets us refer to "Parser.Parse.parsefile" simply as "parsefile",
// and to constructors like "Parser.Parse.APP" simply as "APP".
open Parser_script.Parse

// Here I show you a little bit of the implementation of interp. Note how ERRORs
// are propagated, how rule (6) is implemented, and how stuck evaluations
// are reported using F#'s sprintf function to create good error messages.
let rec interp = function
| APP (e1, e2) ->
    match (interp e1, interp e2) with
    | (ERROR s, ERROR _) ->ERROR s
    | (_, ERROR s) -> ERROR s
    | (SUCC, NUM n) -> NUM (n + 1)      // rule 6
    | (SUCC, v) -> ERROR (sprintf "'succ' needs int argument, not '%A'" v)

// convenitet abbreviations
let interpfile filename = filename |> parsefile |> interp
let interpstr sourcecode = sourcecode |> parsestr |> interp