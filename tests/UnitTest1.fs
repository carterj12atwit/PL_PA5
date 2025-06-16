namespace wit.comp3350

open NUnit.Framework
open wit.comp3350.a5
open wit.comp3350.TestHelper

[<CancelAfter(400)>]
[<TestFixture>]
module tests =
    [<Test>]
    let testTwoMax () =
        assertIsSome 8 (twoMax (Some 1) (Some 8))
        assertIsSome 5 (twoMax (Some 3) (Some 5))
        assertIsSome 3 (twoMax (Some 3) None)
        assertIsSome 5 (twoMax (Some 5) None)
        assertIsSome 8 (twoMax None (Some 8))
        assertIsSome 5 (twoMax None (Some 5))

    [<Test>]
    let testTwoMin () =
        assertIsSome 1 (twoMin (Some 1) (Some 8))
        assertIsSome 3 (twoMin (Some 3) (Some 5))
        assertIsSome 3 (twoMin (Some 3) None)
        assertIsSome 5 (twoMin (Some 5) None)
        assertIsSome 8 (twoMin None (Some 8))
        assertIsSome 5 (twoMin None (Some 5))

    [<Test>]
    let testThreeMax () =
        assertIsSome 8 (threeMax (Some 1) (Some 4) (Some 8))
        assertIsSome 8 (threeMax (Some 8) (Some 4) (Some 3))
        assertIsSome 8 (threeMax (Some 4) (Some 8) (Some 3))
        assertIsSome 8 (threeMax (Some 4) (Some 8) (Some 3))

    [<Test>]
    let testThreeMin () =
        assertIsSome 1 (threeMin (Some 1) (Some 4) (Some 8))
        assertIsSome 3 (threeMin (Some 8) (Some 4) (Some 3))
        assertIsSome 3 (threeMin (Some 4) (Some 8) (Some 3))
        assertIsSome 3 (threeMin (Some 4) (Some 8) (Some 3))

    [<Test>]
    let testTryNth () =
        assertIsSome 11 (tryNth 0 [11; 12])
        assertIsSome 12 (tryNth 1 [11; 12])
        assertIsNone (tryNth 2 [11; 12])
        assertIsSome 11 (tryNth 0 [11])
        assertIsNone (tryNth 1 [11])
        assertIsSome 11 (tryNth 0 [11; 12; 13; 14; 15])
        assertIsSome 15 (tryNth 4 [11; 12; 13; 14; 15])
        assertIsNone (tryNth 5 [11; 12; 13; 14; 15])
        assertIsNone (tryNth 6 [11; 12; 13; 14; 15])
        assertIsNone (tryNth 0 [])

    // A single-entry tree with just 3
    let tree3 = InnerN (EmptyN, 3, EmptyN)

    // A tree with 3 as root, and 1, 6 on either side
    // i.e.   3
    //       1 6
    let tree316 = 
        let lf = InnerN (EmptyN, 1, EmptyN)
        let rt = InnerN (EmptyN, 6, EmptyN)
        InnerN (lf, 3, rt)

    // A tree with 3 as root, 5 and 6 on right, and 9 under 6
    // i.e.  3
    //         6
    //        5 9
    let tree3659 = 
        let c9 = InnerN (EmptyN, 9, EmptyN)
        let c5 = InnerN (EmptyN, 5, EmptyN)
        let c6 = InnerN (c5, 6, c9)
        InnerN (EmptyN, 3, c6)

    [<Test>]
    let testAddAll () =
        assertEquals 0 (addAll EmptyN)
        assertEquals 3 (addAll tree3)
        assertEquals 10 (addAll tree316)
        assertEquals 23 (addAll tree3659)

    [<Test>]
    let testCountSingle () =
        assertEquals 0 (countSingle EmptyN)
        assertEquals 1 (countSingle tree3)
        assertEquals 3 (countSingle tree316)
        assertEquals 4 (countSingle tree3659)

    [<Test>]
    let testToListInOrder () =
        assertListEquals [3] (toListInOrder tree3)
        assertListEquals [1; 3; 6] (toListInOrder tree316)
        assertListEquals [3; 5; 6; 9] (toListInOrder tree3659)

    [<Test>]
    let testInsertBST () =
        let tr = insertBST 3 EmptyN
        assertListEquals [3] (toListInOrder tr)
        let tr = insertBST 9 tr
        assertListEquals [3; 9] (toListInOrder tr)
        let tr = insertBST 1 tr
        assertListEquals [1; 3; 9] (toListInOrder tr)
        let tr = insertBST 7 tr
        assertListEquals [1; 3; 7; 9] (toListInOrder tr)

    [<Test>]
    let testPathSum () =
        assertTrue (pathsum tree3 3)
        assertTrue (pathsum tree316 4)
        assertTrue (pathsum tree316 9)
        assertTrue (pathsum tree3659 3)
        assertTrue (pathsum tree3659 14)
        assertTrue (pathsum tree3659 18)

        assertFalse (pathsum tree3 1)
        assertFalse (pathsum tree3 4)
        assertFalse (pathsum tree3 9)
        assertFalse (pathsum tree316 3)
        assertFalse (pathsum tree316 1)
        assertFalse (pathsum tree316 6)
        assertFalse (pathsum tree316 10)
        assertFalse (pathsum tree3659 6)
        assertFalse (pathsum tree3659 5)
        assertFalse (pathsum tree3659 9)
        assertFalse (pathsum tree3659 12)
        assertFalse (pathsum tree3659 21)
