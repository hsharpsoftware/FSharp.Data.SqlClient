
open FSharp.Data

let get42 = new SqlCommandProvider<"SELECT 42", "Server=(localdb)\MSSQLLocalDB;Integrated Security=True">("Server=(localdb)\MSSQLLocalDB;Integrated Security=True")
get42.Execute() |> Seq.toArray |> printfn "%A" 

