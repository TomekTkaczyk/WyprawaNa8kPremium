using System;

namespace WyprawaNa8kPremium
{
    public class TreeNode<T> : Tree<T> where T : class
    {
        public TreeNode<T> Parrent { get; protected set; }

        public TreeNode(TreeNode<T> parrent, T value) : base(value) 
        {
            Parrent = parrent;
        }
        public TreeNode(T value) : this(null, value) { }

        public override void Dispose()
        {
            base.Dispose();
            if (Parrent != null)
            {
                Parrent = null;
            }
        }

        public void SetLeft(TreeNode<T> left)
        {                           
            Left = left;
        }

        public void SetRight(TreeNode<T> right)
        {
            Right = right;
        }
    }
}
