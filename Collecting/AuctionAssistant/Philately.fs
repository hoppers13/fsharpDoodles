module Philately
    
    type Area = Egeo| IsoleIonie | Sicilia
    type Catalogue = Sassone | Unificato
    type CatalogueNumber = Single of int
                           | Set of int
    type CatalogueReference = Catalogue * Area * CatalogueNumber
    type Stamp = {CatalogueReference: CatalogueReference; Year:int; Description: string; }   

     // to be moved to shared
    let same a b = (compare a b) = 0

    let sameStamp (fst:Stamp) (snd:Stamp) =
        same fst.CatalogueReference snd.CatalogueReference

