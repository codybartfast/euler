// This solution is based on the "Counting Change" example in the Structure 
// and Interpretaion of  Computer Programs by Abelson and Sussman:
//      - http://www.sicp-book.com/book-Z-H-15.html#%_thm_2.19
//      - http://www.sicp-book.com/book-Z-H-11.html#%_sec_1.2.2

let coins = [ 200; 100; 50; 20; 10; 5; 2; 1; ]

let rec coinSums coins sum =
    match coins, sum with 
    | _, 0 -> 1
    | [], _ -> 0
    | _, sum when (sum < 0) -> 0
    | coin::remainingCoins, _ ->
        coinSums coins (sum - coin)
        + coinSums remainingCoins sum
        
coinSums coins 200

// val it : int = 73682
