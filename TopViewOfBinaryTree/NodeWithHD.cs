using System;
using System.Collections.Generic;
using System.Text;

namespace TopViewOfBinaryTree
{
    class NodeWithHD
    {
        BinaryTreeNode binaryTreeNode;

        int horizontalDistance;

        public NodeWithHD() { }

        public NodeWithHD(BinaryTreeNode node, int distance) {
                binaryTreeNode = node;
                horizontalDistance = distance;
        }

        public void SetNode(BinaryTreeNode node) {
            binaryTreeNode = node;
        }

        public void SetHorizontalDistance(int distance) {
            horizontalDistance = distance;
        }

        public int GetHorizontalDistance() {
            return horizontalDistance;
        }

        public BinaryTreeNode GetNode() {
            return binaryTreeNode;
        }
    }
}
