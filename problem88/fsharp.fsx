// A little different. I don't change `nums1` and I dont use the `n` and `m` parameters.
let rec merge (nums1: int list) (nums2: int list) =
    match nums1, nums2 with
    | xs, [] -> xs
    | [], ys -> ys
    | x::xs, y::ys -> 
        if x <= y then x::(merge xs (y::ys))
        else y::(merge ys (x::xs)) 