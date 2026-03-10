open System

// Функция для вычисления произведения цифр числа
let product (n: int) =
    n
    |> abs
    |> string
    |> Seq.map (fun c -> int c - int '0')
    |> Seq.fold (fun acc digit -> acc * digit) 1

// Функция, которая получает список произведений цифр
let getProducts (numbers: int list) =
    numbers |> List.map product

printfn "Исходный список через пробел: "
let input1 = Console.ReadLine()
let list1 = input1.Split(' ') |> Array.toList |> List.map int

let result = getProducts list1

printfn "%A" result