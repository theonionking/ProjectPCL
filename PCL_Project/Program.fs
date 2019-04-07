open System

type Size = | Small | Medium | Large 

type SaladType = | Carrot | Potato | Caesar
type CakeType = | Chocolate | Banana | Strawberry
type SandwichType = | Ham | Beef | Chicken

type SaladDetails = {Food: SaladType; Size: Size}
type CakeDetails = {Food: CakeType; Size: Size}
type SandwichDetails = {Food: SandwichType; Size: Size}

type AllFood = | ViaSalad of SaladDetails | ViaCake of CakeDetails | ViaSandwich of SandwichDetails


let sizeRP size= 
    match size with
    | Small-> 0.5
    | Medium -> 1.0
    | Large -> 1.5         

let getFoodPrice food = 
    match food with 
    | ViaSalad details -> 
        match details.Food with
        | Carrot -> 15.0 * sizeRP details.Size
        | Potato -> 15.0 * sizeRP details.Size
        | Caesar -> 25.0 * sizeRP details.Size
    | ViaCake details -> 
        match details.Food with
        | Chocolate -> 25.0 * sizeRP details.Size
        | Banana -> 20.0 * sizeRP details.Size
        | Strawberry -> 23.0 * sizeRP details.Size
    | ViaSandwich details -> 
        match details.Food with
        | Ham -> 30.0 * sizeRP details.Size
        | Beef -> 30.0 * sizeRP details.Size
        | Chicken -> 25.0 * sizeRP details.Size