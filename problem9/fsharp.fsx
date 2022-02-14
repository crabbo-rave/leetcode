let isPalindrome x = 
    let arr = x.ToString().ToCharArray()
    arr = Array.rev arr

let isPalindrome' (n: int) =
    let x, y = n, 0
    let f = fun x y -> (y*10) + x % 10
    let rec isPalindrome'Rec ((x, y): int * int) =
        match x with 
        | x when x < 1 -> x, y
        | _ -> isPalindrome'Rec (x/10, f x y)
    (snd (isPalindrome'Rec (x, y))) = n