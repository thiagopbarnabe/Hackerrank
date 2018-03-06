using System;

namespace ctci_is_binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node class is defined as follows:
    class Node {
        int data;
        Node left;
        Node right;
     }
*/


//boolean greaterThan(Node n, int parentData, Integer minValue, Integer maxValue)
//{
//    if (n != null)
//    {
//        if (minValue != null && n.data <= minValue)
//            return false;

//        if (maxValue != null && n.data >= maxValue)
//            return false;

//        return n.data > parentData && lessThan(n.left, n.data, minValue, n.data) && greaterThan(n.right, n.data, n.data, maxValue);
//    }
//    else return true;
//}

//boolean lessThan(Node n, int parentData, Integer minValue, Integer maxValue)
//{
//    if (n != null)
//    {
//        if (minValue != null && n.data <= minValue)
//            return false;

//        if (maxValue != null && n.data >= maxValue)
//            return false;

//        return n.data < parentData && lessThan(n.left, n.data, minValue, n.data) && greaterThan(n.right, n.data, n.data, maxValue);
//    }
//    else return true;
//}

//boolean checkBST(Node root)
//{
//    return lessThan(root.left, root.data, null, root.data) && greaterThan(root.right, root.data, root.data, null);
//}