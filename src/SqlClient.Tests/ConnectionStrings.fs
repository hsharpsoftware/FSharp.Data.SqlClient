﻿namespace FSharp.Data

type Settings = FSharp.Configuration.AppSettings<"app.config">

module ConnectionStrings = 

    [<Literal>]
    let AdventureWorksLiteral = @"Data Source=.;Initial Catalog=AdventureWorks2014;Integrated Security=True"
    [<Literal>]
    let AdventureWorksLiteralMultipleActiveResults = AdventureWorksLiteral + ";MultipleActiveResultSets=True"
    [<Literal>]
    let AdventureWorksNamed = @"name=AdventureWorks"
    [<Literal>]
    let AdventureWorksAzure = @"Server=tcp:mhknbn2kdz.database.windows.net,1433;Database=AdventureWorks2012;User ID=sqlfamily;Password= sqlf@m1ly;Trusted_Connection=False;Encrypt=True;Connection Timeout=30"
    [<Literal>]
    let MasterDb = @"name=MasterDb"
    [<Literal>]
    let LocalHost = @"Data Source=.;Integrated Security=True"
