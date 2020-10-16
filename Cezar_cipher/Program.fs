// Learn more about F# at http://fsharp.org

open System


let CezarCipher =
    
    let getText = 
        printfn "Put here text you would like to process:"
        "Ala ma kota".ToLower()
        //Console.ReadLine().ToLower()

    let getShift = 
        printfn "What is the shift of the cipher?"
        "10"
        //Console.ReadLine()
        |> int
    
    //let moveChar (input : char, shift : int, direction : bool) = 
        
    //    let NumericChar = int input

    //    match direction with
    //    | true -> match NumericChar with
    //              | i when i >= 68 && i < 95 -> 71
    //              | _ -> 70
            
    //    | false -> match NumericChar with
    //              | i when i >= 68 && i < 95 -> 71
    //              | _ -> 70
        
    let moveString (input : string) shift =
        
        input.ToCharArray()
        |> List.ofArray
        |> List.map (fun c -> 
            match int c with
                    | i when i + shift > 122 -> i - 26 + shift
                    | i when i + shift < 122 -> i + shift
                    | i when i - shift < 97 -> i + 26 - shift
                    | i when i - shift > 97 -> i - shift
                )
        |> List.map (fun i -> char i)
        |> String.Concat
        //[for c in input do yield (moveChar c shift direction)]

    printfn "Welcome in Cezar Cipher encrypter." 
    Console.WriteLine(moveString getText getShift)

[<EntryPoint>]
CezarCipher
    

    


    

