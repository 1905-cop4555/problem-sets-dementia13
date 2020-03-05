type 'a Coordinates =
    | Tuple of val1: 'a * val2: 'a
    | Threeple of val1: 'a * val2: 'a * val3: 'a
    | Fourple of val1: 'a * val2: 'a * val3: 'a * val4: 'a

let Tuple = (4 , 20) // :)
let Threeple = (3.2, 151.0, 97.8)
let Fourple = ("Farcical aquatic ceremony", "Judean People's Front", "Scott of the Antarctic", "Grale frit")