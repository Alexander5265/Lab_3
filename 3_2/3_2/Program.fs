open System

// функция перевода двоичного числа в десятичное
let binToDec (binary: string) =
    Convert.ToInt32(binary, 2)

// функция для вычисления суммы с помощью Seq.fold
let sumBinaryNumbers (numbers: string list) =
    numbers
    |> Seq.fold (fun sum element ->
        sum + binToDec element) 
        0


[<EntryPoint>]
let main argv =

    printfn "Исходный двоичный список через пробел: "
    let input1 = Console.ReadLine()
    let list1 = input1.Split(' ') |> Array.toList
        
    let result = sumBinaryNumbers list1

    printfn "Сумма = %d" result

    0
