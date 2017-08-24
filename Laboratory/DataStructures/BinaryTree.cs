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
    }

}
