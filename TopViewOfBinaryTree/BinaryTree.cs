using System;
using System.Collections.Generic;
using System.Text;

namespace TopViewOfBinaryTree
{
    class BinaryTree
    {
        private BinaryTreeNode RootNode;

        public BinaryTree() { }

        public void SetRootNode(BinaryTreeNode treeNode) {
            RootNode = treeNode;
        }

        public BinaryTreeNode GetRootNode() {
            return RootNode;
        }
        public BinaryTreeNode Insert(int data) {
            RootNode = _InsertUtil(RootNode, data);
            return RootNode;
        }

        private BinaryTreeNode _InsertUtil(BinaryTreeNode binaryTreeNode, int data) {
            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }

            //Given data is greater than the node's data, so it should go right
            if (binaryTreeNode.GetData() < data)
            {
                binaryTreeNode.SetBinaryNodeRight(
                    _InsertUtil(binaryTreeNode.GetBinaryNodeRight(), data));
            }
            else {
                //If data is less than node's value, navigate left
                binaryTreeNode.SetBinaryNodeLeft(
                    _InsertUtil(binaryTreeNode.GetBinaryNodeLeft(), data)
                    );
            }

            return binaryTreeNode;
        }

        public void TopView() {
            if (RootNode != null)
            {
                Console.WriteLine("-------------Inorder Traversal of constructed tree-----------");
                PrintInorderTraversal(RootNode);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------");
                //Print Top View using Level Order Traversal using Queue
                Console.WriteLine();
                _PrintTopView(RootNode);
            }
            else {
                Console.WriteLine("Given tree is null! There is no top view!");
            }
        }


        public void PrintInorderTraversal(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            PrintInorderTraversal(binaryTreeNode.GetBinaryNodeLeft());
            Console.Write(binaryTreeNode.GetData()+"->");
            PrintInorderTraversal(binaryTreeNode.GetBinaryNodeRight());
        }

        private void _PrintTopView(BinaryTreeNode rootNode) {
            if (rootNode != null) {
                IDictionary<int, BinaryTreeNode> hashMap = new Dictionary<int, BinaryTreeNode>();
                hashMap.Add(0, rootNode);
                Queue<NodeWithHD> queue = new Queue<NodeWithHD>();
                queue.Enqueue(new NodeWithHD(rootNode, 0));

                while (queue != null && queue.Count != 0) {
                    NodeWithHD nodeDequeued = queue.Dequeue();

                    //Insert in Hashmap only if the distance is not present
                    if (nodeDequeued != null) {
                        if (!hashMap.ContainsKey(nodeDequeued.GetHorizontalDistance())) {
                            hashMap.Add(nodeDequeued.GetHorizontalDistance(), nodeDequeued.GetNode());
                        }

                        if (nodeDequeued?.GetNode()?.GetBinaryNodeLeft() != null) {
                            int leftDistance = nodeDequeued.GetHorizontalDistance() - 1;
                            queue.Enqueue(new NodeWithHD(
                                nodeDequeued.GetNode().GetBinaryNodeLeft(),
                                leftDistance)
                                );
                        }

                        if (nodeDequeued?.GetNode()?.GetBinaryNodeRight() != null) {
                            int rightDistance = nodeDequeued.GetHorizontalDistance() + 1;
                            queue.Enqueue(new NodeWithHD(
                                nodeDequeued.GetNode().GetBinaryNodeRight(),
                                nodeDequeued.GetHorizontalDistance() + 1)
                                );
                        }
                    }
                }
                //HashMap will have the elements in the top view
                PrintHashMap(hashMap);
            }
        }
        private void PrintHashMap(IDictionary<int, BinaryTreeNode> keyValuePairs) {
            Console.WriteLine("-------------------Result-----------------");
            Console.WriteLine("Elements in Top View of the Binary Tree are as follows");

            foreach (KeyValuePair<int, BinaryTreeNode> keyValue in keyValuePairs) {
                Console.WriteLine(keyValue.Value.GetData());
            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
        }
    }
}
