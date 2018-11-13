using System;

namespace TopViewOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Top View of Binary Tree!");
            Console.WriteLine("------------------------");

            BinaryTree binaryTree = ConstructTreeFromInput();
            binaryTree.TopView();

            Console.ReadLine();
        }

        private static BinaryTree ConstructTreeFromInput() {
            BinaryTree binaryTree = null;

            Console.WriteLine("Enter the number of elements to form the tree");
            try
            {
                binaryTree = new BinaryTree();
                int noOfElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] allElements = Console.ReadLine().Split(' ');

                for (int i = 0; i < noOfElements; i++){
                    binaryTree.SetRootNode(binaryTree.
                        Insert(int.Parse(allElements[i])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return binaryTree;
        }
    }
}
