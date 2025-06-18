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

    /// TODO: Complete and document
    let rec tryNth n l =
        None

    /// <summary>This type represents a binary tree. A binary tree can either be
    ///  - An empty node
    ///  - An inner node that also contains data
    /// </summary>
    type BinaryTree<'a> =
        | EmptyN
        | InnerN of BinaryTree<'a> * 'a * BinaryTree<'a>

     /// TODO: Document this and complete it
    let rec addAll t =
        0
    
    /// TODO: Document this and complete it
    let rec countSingle t =
        0

    /// TODO: Complete and document
    let rec toListInOrder tr =
        [-1]

    /// TODO: Complete and document
    let rec insertBST x tr =
        EmptyN

    /// TODO: Complete and document
    let rec pathsum tr s = 
        false
