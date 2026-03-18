open System

// Функция для вычисления произведения цифр числа
let product (n: int) =
    n
    |> abs
    |> string
    |> Seq.map (fun c -> int c - int '0')
    |> Seq.fold (fun acc digit -> acc * digit) 1

// Функция, которая получает последовательность произведений цифр
let getProducts (numbers: seq<int>) =
    numbers |> Seq.map product

[<EntryPoint>]
let main argv =

    printfn "Исходная последовательность через пробел:"
    let input1 = Console.ReadLine()

    let seq1 =
        input1.Split(' ')
       |> Seq.map int

    let result = getProducts seq1
    printfn "%A" result

    0
