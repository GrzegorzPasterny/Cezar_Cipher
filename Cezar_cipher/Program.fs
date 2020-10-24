open System


let CezarCipher =
    Console.WriteLine("Welcome in Cezar Cipher encrypter.")
    
    let getText = 
        printfn "Put here text you would like to process:"
        //"Ala ma kota".Trim().ToLower()
        Console.ReadLine().Replace(" ","").ToLower()

    let getShift = 
        printfn "What is the shift of the cipher?"
        //"10"
        Console.ReadLine()
        |> int
    
    let getShiftMod = 
        getShift % 26

    let moveString (input : string) shift =
        
        input.ToCharArray()
        |> List.ofArray
        |> List.map (fun c -> 
            match int c with
                    | i when i + shift > 122 -> i - 26 + shift
                    | i when i + shift <= 122 && i + shift >= 97 -> i + shift
                    | i when i + shift < 97 -> i + 26 + shift
                    )
        |> List.map (fun i -> char i)
        |> String.Concat

    Console.WriteLine(moveString getText getShiftMod)

[<EntryPoint>]
CezarCipher