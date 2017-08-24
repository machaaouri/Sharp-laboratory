namespace DataStructures
{
    public class TNode
    {
        public int Data { get; set; }
        public TNode Left;
        public TNode Right;
        public TNode Parent;
        
        public TNode(int d)
        {
            Data = d;
            Left = null;
            Right = null;
            Parent = null;
        }


    }

    public class Tree
    {
        public TNode root;


        public void add(int data)
        {
            Insert(ref root, data);
        }

        public void Insert(ref TNode root, int data)
        {
            if (root == null)
            {
                TNode newNode = new TNode(data);
                root = newNode;
            }

            else
            {

                if (data < root.Data)
                {
                    Insert(ref root.Left, data);
                    root.Left.Parent = root;
                }
                else
                {
                    Insert(ref root.Right, data);
                    root.Right.Parent = root;
                }

            }

        }

        public void Delete(ref TNode tree , int target)
        {
            if (root == null) return;

            else if (target < tree.Data) Delete(ref tree.Left, target);
            else if (target > tree.Data) Delete(ref tree.Right, target);
            else // found node to be deleted
            {
                if(tree.Left != null && tree.Right != null) // 2 children
                {
                    TNode min = findMin(tree.Right);
                    tree.Data = min.Data;
                    Delete(ref tree.Right, tree.Data);

                   
                }
                else // one or zero child
                {
                    if (tree.Left == null)
                    {
                        if (tree.Parent == null) this.root = tree.Right; // the target match the root which has no left child (root is deleted)
                        else
                        {
                            if (tree.Right != null)
                            {
                                tree.Right.Parent = tree.Parent;
                            }

                            if (tree == tree.Parent.Left)
                                tree.Parent.Left = tree.Right;
                            else tree.Parent.Right = tree.Right;
                        }
                    }
                    else if(tree.Right == null)
                    {
                        if (tree.Parent == null) this.root = tree.Left;
                        else
                        {
                            tree.Left.Parent = tree.Parent;
                            if (tree == tree.Left.Parent)
                                tree.Parent.Left = tree.Left;
                            else
                                tree.Parent.Right = tree.Left;
                        }
                    }
                    
                }
            }
        }

        public TNode findMin(TNode root)
        {
            if (root == null) return null;
            else if (root.Left == null) return root;
            else return findMin(root.Left);
        }

        public TNode findMax(TNode root)
        {
            if (root == null) return null;
            else if (root.Right == null) return root;
            else return findMax(root.Right);
        }

        //Given a sorted (increasing order) array, write an algorithm to create a binary tree with minimal height

        public TNode CreateBST(int[] A,int start,int end)
        {
            if (end < start) return null;

            int mid = (start + end) / 2;
            TNode node = new TNode(A[mid]);
            node.Right = CreateBST(A, mid + 1,end);
            node.Left = CreateBST(A, start, mid - 1);
            return node;
        }

        //Check if T2 is a subtree of T1

        public bool isSubtree(TNode T1,TNode T2)
        {
            if (T1 == null) return true; //Big tree empty and T2 hasn't been fond
            if(T1.Data == T2.Data )
            {
                if (matchTree(T1, T2)) return true;
            }
            return (isSubtree(T1.Left, T2) || isSubtree(T1.Right, T2));
        }

        private bool matchTree(TNode t1, TNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;

            if (t1.Data != t2.Data) return false;
            return matchTree(t1.Left, t2.Left) && matchTree(t1.Right, t2.Right);
        }
    }

}
