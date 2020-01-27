let rec gcd = function
    |   (a, 0) -> a
    |   (a, b) -> gcd(b, a % b)

let a, b, c, d = (2, 4, 6, 8)
let (.+) (a, b) (c, d) = ((a * d + c * b), (b * d))
let (.*) (a, b) (c, d) = a * c, b * d
let ad = (a, b) .+ (c, d)
let red = fst ad / gcd ad, snd ad / gcd ad
let mul = (a, b) .* (c, d)
let rem = fst mul / gcd mul, snd mul / gcd mul