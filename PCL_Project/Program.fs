
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


let getStrRep food = 
    match food with 
    | ViaSalad details -> sprintf "ViaSalad %A" details.Food
    | ViaCake details -> sprintf "ViaCake %A" details.Food
    | ViaSandwich details -> sprintf "ViaSandwich %A" details.Food


type CanteenMessage = | OrderFood of AllFood * int 
                      | LeaveAComment of string


let canteenFoodAgent = MailboxProcessor<CanteenMessage>.Start(fun inbox-> 

    // the message processing function
    let rec messageLoop() = async{
        
        // read a message
        let! msg = inbox.Receive()
        
        // process a message
        match msg with
        | OrderFood (food, qty) -> printfn "Please pay DKK%.1f for your order of %d %s. Thanks!" ((getFoodPrice food)*(float qty)) qty (getStrRep food)
        | LeaveAComment comment -> printfn "Thank you very much for your comment. Our canteen operators will look into it soon! Have a good day!\nYour comment was: \"%s\"" comment

        // loop to top
        return! messageLoop()  
        }

    // start the loop 
    messageLoop() 
    )