module Philately
    
open Kernel

    type State = Any| Used | NoGum | MH | MNH 
    type Condition = P | G | F | VF | SPL  // Poor; Good; Fine; Very FIne; Splendid 
    type Area = Egeo| IsoleIonie | Sicilia
    type Catalogue = Sassone | Unificato
    type CatalogueNumber = Single of int
                           | Set of int 
                           | PostalHistory
    type CatalogueReference = Catalogue * Area * CatalogueNumber
    type Stamp = {CatalogueReference: CatalogueReference; Year:int; Description: string; State: State; Condition: Condition  }   
    
    let sameStamp (fst:Stamp) (snd:Stamp) =
        fst.CatalogueReference |== snd.CatalogueReference

    let sameStampOfEquivalentQuality (fst:Stamp) (snd:Stamp) =
        (fst.CatalogueReference, fst.State, fst.Condition) |== (snd.CatalogueReference, snd.State, snd.Condition) 