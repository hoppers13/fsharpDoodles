﻿module Numismatic

open Kernel

     type Area = Italia| Svizzera | GranBretagna
     type Catalogue = {Name: string; Year: int}
     type CatalogueNumber = Single of int
                           | Set of int
     type CatalogueReference = Catalogue * Area * CatalogueNumber
     type Coin = {CatalogueReference: CatalogueReference; Year:int; Description: string; }  

     let sameCoin (fst:Coin) (snd:Coin) =
        fst.CatalogueReference |== snd.CatalogueReference