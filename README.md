
Author : Giruba Beulah SE
# TopViewOfBinaryTree
C# program for printing the elements in the Top View of Binary Tree/BST

The idea is to use Level Order Traversal and Horizontal distance to put nodes in a Hashmap.

For Example: Consider the following tree containing 7 nodes
        100
      |     |
    50      250
  |   |    |    |
  10  70   150  300  
  
  
  Now, root node = 100 whose horizontal diastance will be 0.
  Horizontal distance of a left node is distance from its previous node -1
  So, for 50, the horizontal distance will be -1
  
  Horizontal distance of a right node is distance from its previous node + 1
  So, for 250 the horizontal distance is 1
  
  For 10 , Horizontal distance is -2  For 70, the horizontal distance is -1+1 = 0 [Note that 70 is a right node on left]
  
  For 150, the horizontal distance is 1-1 = 0 [150 is a left node on right]
  The horizontal distance of 300 is 2
  
  We see that usually root will have horizontal distance of 0.
  There are two nodes however, which have 0 as horizontal distance which are 70 and 150 which fall exactly beneath the root.
  However, 70 and 150 are invisible from the top as the root hides them.
  
  The other nodes have distinct horizontal distance so they are visible from top view unlike 70 and 150.
  
  
  Logic/Algorithm:
  ----------------
  1. Insert the root in a HashMap with a horizontal distance(HD) of 0
  2. Initialize a Queue with the rootNode+HD
  3. While queue is not empty do the following
      3.a  Dequeue the node in the queue, let it be nodespecial which has both the root node and its HD
      3.b  If the HD is not present in HashMap, push it to the HashMap so that only the first(/Top) node is given preference 
      3.c If the dequued node has a left, enqueue it where it's HD will be dequeuedNode's distance-1
      3.d Similarly if the dequeued node has a right, enqueue it's HD which is dequeuedNode's distance+1
 4. Print the Values of the Nodes in the HashMap
 
 Note: In C#, Dictionary is used for HashMap.
  
  
  
  
