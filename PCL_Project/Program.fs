open System

type Size = | Small | Medium | Large 
type Food = | Cake | Salad | Sandwich
type Product = {name: Food; size: Size}

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

let getTypeFromString smth = 
    match smth.ToString().ToLower() with 
    |"cake" -> Cake
    |"salad" -> Salad
    |"sandwich" -> Sandwich

let getSizeFromSring smth = 
    match smth.ToString().ToLower() with 
    |"small" -> Small
    |"medium" -> Medium
    |"large" -> Large

let getPriceForOption fType fSize =
    let a = getTypeFromString fType
    let b = getSizeFromSring fSize 
    let c = {name=a; size=b}
    getFoodPrice c

[<EntryPoint>]
let main args= 
    printf("Enter the name of the food: options are salad/sandwich/cake \n")
    let foodtype = Console.ReadLine();
    printf("Enter the size of the food: options are small/medium/large \n")
    let foodsize = Console.ReadLine();
    let x = getPriceForOption foodtype foodsize
    Console.WriteLine("Price is {0}", x)
    Console.ReadLine() |> ignore
    0