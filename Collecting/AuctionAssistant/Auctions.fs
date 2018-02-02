module Auctions

open Philately
open Numismatic

    type Amount = decimal
    type Collectable =    Stamp of Stamp
                        | Coin of Coin                        
                        | Map


    
    type Wish = {Item: Collectable; Desirability: int}
    type Wishlist = Wish list
    type Auctionable = {Item: Collectable; StartingPrice: Amount}
    type AuctionedItems = Auctionable list
    type BudgetConstraints = {Budget: Amount; }
    type Bid = {AuctionItem: Collectable; SuggestedBid: Amount}
     
      
    


    // goal!!
    // let suggestedBids = Compare wishlist auctionedItems |> applying budgetConstrains 