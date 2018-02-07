module PhilatelyTests

open Xunit

open Kernel
open Philately

[<Fact>]
let ``should compare similar stamps`` () =
    let first = {CatalogueReference = (Sassone, Egeo, Set 1); Year = 1912; Description = "Stamps of Italy 1908 overprinted"; State = State.MNH; Condition = Condition.VF}
    let second = {CatalogueReference = (Sassone, Egeo, Set 1); Year = 1912; Description = "Egeo overprints"; State = MH; Condition = F}
    let comparison = sameStamp first second 
    Assert.True(comparison)


[<Fact>]
let ``should compare different stamps`` () =
    let first = {CatalogueReference = (Sassone, Egeo, Set 1); Year = 1912; Description = "Stamps of Italy 1908 overprinted"; State = State.MNH; Condition = Condition.VF}
    let second = {CatalogueReference = (Sassone, Egeo, Set 2); Year = 1929; Description = "Pittorica"; State = MNH; Condition = Condition.VF}
    let comparison = sameStamp first second 
    Assert.False(comparison)
