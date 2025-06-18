namespace wit.comp3350

module a5 =
    /// <summary> returns the maximum of two integers </summary>
    /// <params> two int option types </params>
    /// <returns> the max of the two integers </returns>
    let twoMax (aop: 'a option) (bop: 'a option) =
        match aop, bop with
        | Some aop, Some bop -> if aop > bop then Some aop else Some bop
        | Some aop, None -> Some aop
        | None, Some bop -> Some bop
        | None, None -> None

    /// <summary> returns the minimum of two integers </summary>
    /// <params> two int option types </params>
    /// <returns> the minimum of the two integers </returns>
    let twoMin (aop: 'a option) (bop: 'a option) =
        match aop, bop with
        | Some aop, Some bop -> if aop < bop then Some aop else Some bop
        | Some aop, None -> Some aop
        | None, Some bop -> Some bop
        | None, None -> None


    /// <summary> returns the maximum of three integers </summary>
    /// <params> three int option types </params>
    /// <returns> the maximum of the three integers </returns>
    let threeMax (aop: 'a option) (bop: 'a option) (cop: 'a option) =
        twoMax (twoMax aop bop) (twoMax bop cop)

    /// <summary> returns the minimum of three integers </summary>
    /// <params> three int option types </params>
    /// <returns> the minimum of the three integers </returns>
    let threeMin (aop: 'a option) (bop: 'a option) (cop: 'a option) =
        twoMin (twoMin aop bop) (twoMin bop cop)

    /// <summary> returns an element from a specific index of a list if it exists </summary>
    /// <params> a list and a desired index </params>
    /// <returns> either None of the element at the specified index </returns>
    let rec tryNth n l =
        if List.length l <= n then None else Some (List.item n l)

    /// <summary>This type represents a binary tree. A binary tree can either be
    ///  - An empty node
    ///  - An inner node that also contains data
    /// </summary>
    type BinaryTree<'a> =
        | EmptyN
        | InnerN of BinaryTree<'a> * 'a * BinaryTree<'a>

    /// <summary> adds all the values in a binary tree </summary>
    /// <params> a binary tree </params>
    /// <returns> the total sum of all nodes in the binary tree </returns>
    let rec addAll t =
        match t with
        | EmptyN -> 0
        | InnerN (c1, x, c2) -> x + addAll c1 + addAll c2
    
    /// <summary> tracks all values in the tree that are less than 10 </summary>
    /// 
    let rec countSingle t =
        match t with 
        | EmptyN -> 0
        | InnerN (c1, x, c2) -> if x < 10 then 1 + countSingle c1 + countSingle c2 else countSingle c1 + countSingle c2

    /// TODO: Complete and document
    let rec toListInOrder tr =
        [-1]

    /// TODO: Complete and document
    let rec insertBST x tr =
        EmptyN

    /// TODO: Complete and document
    let rec pathsum tr s = 
        false
