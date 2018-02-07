module Auctions

open Kernel
open Philately
open Numismatic

type Amount = decimal
type Collectable =    Stamp of Stamp
                    | Coin of Coin                        
                    | Map
    
type Wish = {Item: Collectable; Desirability: int}
type Wishlist = Wish list
type Auctionable = {Item: Collectable; AuctionHouse: string; StartingPrice: Amount}
type AuctionedItems = Auctionable list
type BudgetConstraints = {Budget: Amount; }
type Bid = {AuctionItem: Auctionable; SuggestedBid: Amount}
    
let sameCollectable fst snd = 
    match (fst, snd) with
    | (Stamp fst, Stamp snd) -> sameStamp fst snd
    | (Coin fst, Coin snd) -> sameCoin fst snd
    | _ -> false
    
let nextBid (auctioned: AuctionedItems) (wish: Wish) =
    let matches = Seq.where(fun act -> sameCollectable wish.Item act.Item)
    // find best match
    // estimate bid
    // return bid
    matches



let first = Stamp { CatalogueReference = (Sassone, Egeo, Philately.Single 12); 
                    Year = 1930; 
                    Description = "Congresso Idrologico 5 c."; 
                    State = MH; 
                    Condition = F}
    
let second = Coin { CatalogueReference = ({Name = "Spink"; Year = 2015}, Italia, Single 2387); 
                    Year = 1922; 
                    Description = "Some coin"}


let check = sameCollectable first second

    



    // sort wishlist by desirability

    // recursion
        // match most desirable item against auctioned items 
        // suggest a bid
        // re-asses budget (considering budget rules)
    // end resursion
    
    // result: list of suggested bids

    // goal!!
    // let suggestedBids = Compare wishlist auctionedItems |> applying budgetConstrains 