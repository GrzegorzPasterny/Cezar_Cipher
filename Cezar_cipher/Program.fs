// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let CezarCipher =
    
    let getText = 
        printfn "Put here text you would like to process:"
        Console.ReadLine().ToUpper()

    let getShift = 
        printfn "What is the shift of the cipher?"
        Console.ReadLine()
        |> int
    
    let alphabet = "ABCDEFGHIJKLMNOPQRSTUWXYZ"

    let moveChar (input : char, shift : int, direction : bool) = 
        
        let findStartPosition c = 
            alphabet.ToCharArray()
            |> Seq.ofArray
            |> Seq.findIndex (fun i -> i = c)

        let shiftChar positionInAlbhabet movement =
             
             let dumbTotal = positionInAlbhabet + movement
             
             match dumbTotal with
             | t when t > alphabet.Length -> t - alphabet.Length
             | _ -> dumbTotal

        shiftChar (findStartPosition input) shift

    let moveString input shift direction =
        
        input.ToCharArray()
        |> List.ofArray
        |> List.forall (fun c -> moveChar c shift direction)

        //[for c in input do yield (moveChar c shift direction)]

    let performDecryption = 
        moveString getText getShift -1

    let performEncryption = 
        moveString getText getShift 1


    printfn "Welcome in Cezar Cipher encrypter. Do you want to encrypt or decrypt Cezar cipher? //\\True (1); False (0); other character to exit)//\\" 
    match Console.ReadLine() with
        | "0" -> performDecryption
        | "1" -> performEncryption
        | _ -> 0

CezarCipher |> ignore
    

    


    

