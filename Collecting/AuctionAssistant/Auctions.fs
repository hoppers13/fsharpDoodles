module Auctions

    type Amount = decimal
    type Collectable =    Stamp of Philately.Stamp
                        | Coin of Numismatic.Coin                        
                        | Map


    
    type Wish = {Item: Collectable; Desirability: int}
    type Wishlist = Wish list
    type Auctionable = {Item: Collectable; StartingPrice: Amount}
    type AuctionedItems = Auctionable list
    type BudgetConstraints = {Budget: Amount; }
    type Bid = {AuctionItem: Collectable; SuggestedBid: Amount}
     
      
    


    // goal!!
    // let suggestedBids = Compare wishlist auctionedItems |> applying budgetConstrains 