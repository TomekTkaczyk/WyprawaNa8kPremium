namespace WyprawaNa8kPremium
{
    public class TreeWithLeafs
    {
        private readonly int?[] _tree;

        public TreeWithLeafs(int?[] tree)
        {
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
