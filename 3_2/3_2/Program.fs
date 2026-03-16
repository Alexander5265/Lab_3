open System

// функция перевода двоичного числа в десятичное
let binToDec (binary: string) =
    Convert.ToInt32(binary, 2)

// функция для вычисления суммы с помощью Seq.fold
let sumBinaryNumbers (numbers: seq<string>) =
    numbers
    |> Seq.fold (fun sum element ->
        sum + binToDec element)
        0

[<EntryPoint>]
let main argv =

    printfn "Исходная двоичная последовательность через пробел:"
    let input1 = Console.ReadLine()

    let seq1 =
        input1.Split(' ')
        |> Seq.map id

    let result = sumBinaryNumbers seq1
    printfn "Сумма = %d" result

    0
