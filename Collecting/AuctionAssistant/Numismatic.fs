module Numismatic

     type Area = Egeo| IsoleIonie | Sicilia
     type Catalogue = {Name: string; Year: int}
     type NumberType = Single| Set
     type CatalogueNumber = NumberType of int
     type CatalogueReference = Catalogue of CatalogueNumber
     type Coin = {Area: Area; CatalogueNumber: CatalogueNumber; Year:int; Description: string; }  

