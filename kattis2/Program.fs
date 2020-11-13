// Learn more about F# at http://fsharp.org

open System


let SayHello name =
    printfn "hej %s" name

let TakeTwoStone() =
    let line = System.Console.ReadLine()
    let input = line |> int
    if input % 2 = 0
        then System.Console.WriteLine("Bob")
    else System.Console.WriteLine("Alice")

let Faktor() =
    let line = System.Console.ReadLine().Split(" ")
    let firstNumber = line.[0] |> int
    let secondNumber = line.[1] |> int
    let result = firstNumber * (secondNumber - 1) + 1
    System.Console.WriteLine(result)
    
let StuckInATimeLoop() =
    let line = System.Console.ReadLine()
    let number = line |> int
    for curr in 1 .. number do
        printfn("%i Abracadabra") curr

let SolvingForCarrots() =
    let line = System.Console.ReadLine().Split(" ")
    // let n = line.[0] |> int
    let p = line.[1] |> int

    printfn("%i") p
    // for i in 1 .. n do
    //     let nextLine = System.Console.ReadLine()
      
// let SpeedLimit() =
    // let line = System.Console.ReadLine()
    // while line != null do


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
