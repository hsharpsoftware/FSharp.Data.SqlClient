﻿module FSharp.Data.ConnectionStrings 

[<Literal>]
let server = @"(localdb)\MSSQLLocalDB"

[<Literal>]
let AdventureWorksLiteral = @"Data Source=" + server + ";Initial Catalog=AdventureWorks2012;Integrated Security=True"
[<Literal>]
let AdventureWorksDesignOnly = @"name=AdventureWorksDesignOnly"
[<Literal>]
let AdventureWorksLiteralMultipleActiveResults = AdventureWorksLiteral + ";MultipleActiveResultSets=True"
[<Literal>]
let AdventureWorksNamed = @"name=AdventureWorks"
[<Literal>]
let MasterDb = @"name=MasterDb"
[<Literal>]
let LocalHost = @"Data Source=" + server + ";Integrated Security=True"
[<Literal>]
let AdventureWorksAzureRedGate = @"Data Source=mhknbn2kdz.database.windows.net;Initial Catalog=AdventureWorks2012;User ID=sqlfamily;Pwd=sqlf@m1ly"

open FSharp.Configuration
let AdventureWorks = AppSettings<"app.config">.ConnectionStrings.AdventureWorks
