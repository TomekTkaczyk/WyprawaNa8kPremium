using System;

namespace WyprawaNa8kPremium
{
    public class TreeWithLeafs
    {
        private readonly int?[] _tree;

        public TreeWithLeafs(int?[] tree)
        {
            if(tree.Length > (10000))
            {
                throw new ArgumentOutOfRangeException("The tree is too big.");
            }
            if (tree.Length < 1 )
            {
                throw new ArgumentOutOfRangeException("The tree is too small.");
            }
            if (tree == null)
            {
                throw new ArgumentNullException();
            }

            _tree = tree;
        }          

        public int LovestLevelLeafsSumValue()
        {
            var countLeafsOnLevel = 1;
            var countLeafsOnNextLevel = countLeafsOnLevel * 2;
            var pointer = 0;
            int sum = 0;
            while(_tree.Length > pointer)
            {
                sum = 0;
                for(int i = 0; i < countLeafsOnLevel; i++)
                {
                    if(_tree[pointer] == null)
                    {
                        countLeafsOnNextLevel -= 2;
                    }
                    else
                    {
                        if(_tree[pointer].Value > 100)
                        {
                            throw new ArgumentOutOfRangeException("The node value is too large.");
                        }
                        sum += _tree[pointer].Value;
                    }
                    if( ++pointer == _tree.Length)
                    {
                        break;
                    }
                }
                countLeafsOnLevel = countLeafsOnNextLevel;
                countLeafsOnNextLevel *= 2;
            }

            return sum;
        }
    }
}
