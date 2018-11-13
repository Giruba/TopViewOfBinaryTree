using System;
using System.Collections.Generic;
using System.Text;

namespace TopViewOfBinaryTree
{
    class BinaryTreeNode
    {
        int data;

        BinaryTreeNode leftNode;

        BinaryTreeNode rightNode;

        public BinaryTreeNode(int data) {
            this.data = data;
        }

        public int GetData() {
            return data;
        }

        public void SetBinaryNodeData(int data) {
            this.data = data;
        }

        public void SetBinaryNodeLeft(BinaryTreeNode left) {
            leftNode = left;
        }

        public void SetBinaryNodeRight(BinaryTreeNode right) {
            rightNode = right;
        }

        public BinaryTreeNode GetBinaryNodeLeft(){
            return leftNode;
        }

        public BinaryTreeNode GetBinaryNodeRight(){
            return rightNode;
        }
    }
}
