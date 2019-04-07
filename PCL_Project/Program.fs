
open System

type Size = | Small | Medium | Large 
type FoodType = | Cake | Salad | Sandwich
type Product = {name: string; foodType: FoodType; size: Size}



let sizeRP size= 
    match size with
    |Small-> 0.5
    |Medium -> 1.0
    |Large -> 1.5
    |_ -> 1.0
         
let getFoodPrice pr = 
    match pr.foodType with 
    | Cake -> 30.0  * sizeRP pr.size
    | Salad -> 20.0 * sizeRP pr.size 
    | Sandwich -> 25.0 * sizeRP pr.size





//OBSOLETE:: NOT REQUIRED
let getTypeFromString smth = 
    match smth with 
    |"cake" -> Cake
    |"salad" -> Salad
    |"sandwich" -> Sandwich

let getSizeFromSring smth = 
    match smth with 
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