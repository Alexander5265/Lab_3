open System
open System.IO

// Проверяет, существует ли файл с заданным именем
let fileExists (directoryPath: string) (fileName: string) =
    Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories)
    |> Seq.exists (fun file ->
        Path.GetFileName(file) = fileName)

let noMistakes directoryPath fileName =
    try 
        if fileExists directoryPath fileName then
            printfn "Файл найден."
        else
            printfn "Файл не найден."
    with 
        | _ -> printfn "Ошибка ввода!"


[<EntryPoint>]
let main argv =

    printf "Введите путь к каталогу: "
    let directoryPath = Console.ReadLine()

    printf "Введите имя файла: "
    let fileName = Console.ReadLine()

    noMistakes directoryPath fileName
    0
