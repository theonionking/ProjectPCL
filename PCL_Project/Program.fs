
// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

type Size = | Small | Medium | Large 
type Food = | Cake | Salad | Sandwich
type Product = { name: Food; size: Size}

let sizeRP size= 
    match size with
    |Small-> 0.5
    |Medium -> 1.0
    |Large -> 1.5
    |_ -> 1.0
         
let getFoodPrice pr = 
    match pr.name with 
    | Cake -> 30.0  * sizeRP pr.size
    | Salad -> 20.0 * sizeRP pr.size 
    | Sandwich -> 25.0 * sizeRP pr.size
