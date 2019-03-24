
// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

type Size = | Small | Medium | Large 
type Food = | Cake | Salad | Sandwich
type Product = | Cake of Size | Salad of Size | Sandwich of Size

let calc_price food_type size = 
    match food_type with 
    |"salad" -> 30 * sizeRP size
    |"sandwich" -> 25* sizeRP size
    |"cake" -> 20 * sizeRP size
    |_ -> 0




let sizeRP size= 
    match size with
    |"small" -> 0.5
    |"medium" -> 1.0
    |"large" -> 1.5
    |_ -> 1.0



[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
