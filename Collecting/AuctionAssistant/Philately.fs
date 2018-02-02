module Philately
    
open Kernel

    type Area = Egeo| IsoleIonie | Sicilia
    type Catalogue = Sassone | Unificato
    type CatalogueNumber = Single of int
                           | Set of int
    type CatalogueReference = Catalogue * Area * CatalogueNumber
    type Stamp = {CatalogueReference: CatalogueReference; Year:int; Description: string; }   


    let sameStamp (fst:Stamp) (snd:Stamp) =
        same fst.CatalogueReference snd.CatalogueReference

