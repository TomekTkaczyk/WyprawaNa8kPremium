using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WyprawaNa8kPremium
{
    public class Tree<T> : IDisposable where T : class
    {
        const int maxNodeCount = 10000;

        public T Value { get; set; }
        public TreeNode<T> Left { get; protected set; }
        public TreeNode<T> Right { get; protected set; }

        public Tree(T value)
        {
            Value = value;
        }

        public Tree(T[] root)
        {
            if (root.Length > maxNodeCount)
            {
                throw new ArgumentException("Zbyt duża ilość nodów");
            }
        }

        public bool IsLeaf
        {
            get
            {
                return (Left != null) && (Right != null);
            }
        }

        public virtual void Dispose()
        {
            Left.Dispose();
            Right.Dispose();
        }
    }
}
