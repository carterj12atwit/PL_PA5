# Take-home Assignment 5

## Introduction

This assignment provides a comprehensive overview of various F# programming constructs.

## Background

### Running Tests

There are two ways of running the tests. First is to use the terminal (menubar "Terminal" > "New
Terminal" and use the following command:

    dotnet test

Another is to install the "Ionide for F#" extension in Visual Studio Code. In the "Testing" tab
(looks like a chemistry flask), you should be able to run the tests there.

### Grading

There are unit tests provided. Make sure you pass all the unit tests *completely*. Partially passing
a test will not be enough.

In addition to correctness, I will be grading the following items:

- Documentation: Every function should have the correct style of documentation (see below for
  details).
- Code Formatting: The code should be "neat" with proper indentation
- Code Quality: I may deduct points for "quality" but you can earn them back after fixing them.

### Documentation

Every function should have a corresponding XML documentation.

    /// <summary>Returns the absolute value of a number</summary>
    /// <param name="x">The number</param>
    /// <returns>The absolute value </returns>
    let abs x =
        if (x >= 0) then x
        else (-x)

### twoMax/twoMin/threeMax/threeMin

These functions take two or three option types. If all of them are None, return None. If some are
not None, return the largest/smallest of them as a Some type. 

For example, for twoMax:

|     A  |     B  | Return |
| ------ | ------ | ------ |
| Some 3 | Some 5 | Some 5 |
|  None  | Some 5 | Some 5 |
| Some 4 |  None  | Some 4 |
|  None  |  None  |  None  |

and for twoMin:


|     A  |     B  | Return |
| ------ | ------ | ------ |
| Some 3 | Some 5 | Some 3 |
|  None  | Some 5 | Some 5 |
| Some 4 |  None  | Some 4 |
|  None  |  None  |  None  |

### tryNth

`tryNth` takes in an index `n` and a list `l`. This function returns the item at the specified
index, if available. However, if the list is shorter than n, you need to return `None`


|     n  |     l  | Return |
| ------ | ------ | ------ |
|     0  |   [4]  | Some 4 |
|     0  | [4; 7] | Some 4 |
|     1  | [4; 7] | Some 7 |
|     2  | [4; 7] |  None  |
|    -1  | [4; 7] |  None  |


### addAll

This function takes in the binary tree we discussed in class. It adds up all the items in the tree. For example, the following tree:

      3
     / \
    1   6
         \
          11

Should return 1+3+6+11.

### countSingle

This function counts how many elements in a tree are single digit (between 0 and 9 inclusive). For example, the above tree returns 3

### toListInOrder

This function reads a binary tree, traverses it in order adding each element to a list. For example, the following tree:

      3
     / \
    1   6
       / \
      4   9

Should return `[1; 3; 4; 6; 9]` Add 1 first, then the 3, all of the subtree at 6 (which is 4, 6,
then 9).

### insertBST

This function is given a value and binary search tree, and inserts the value in the correct location. For example, given the following tree:

      5
     / \
    2   7
       / \
      6   9

and value 1, you should return:

        5
       / \
      2   7
     /    / \
    1    6   9

and then if you call insertBST with 4, you should return:


and value 1, you should return:

        5
       / \
      2   7
     / \  / \
    1  4 6   9

### pathsum

This assignment is adapted from LeetCode [[1]](#ref1).

A path of a binary tree is a sequence of values from the root to a leaf node, and the pathsum is the
sum of all elements. If the tree is empty, the pathsum is 0.

This function computes pathsums of a binary tree, and returns `true` if at least one path returns
the sum identical to target sum.

For example, given this tree `tr`:

      5
     / \
    2   7
       / \
      6   9

- pathsum tr 7 returns true (5 + 2)
- pathsum tr 18 returns true (5 + 7 + 6)
- pathsum tr 21 returns true (5 + 7 + 9)
- pathsum tr 5 returns false

and given an empty tree:

- pathsum EmptyN 0 returns true
- pathsum EmptyN 2 returns true
    
## References

- <a id="ref1">[1]</a>https://leetcode.com/problems/path-sum/
