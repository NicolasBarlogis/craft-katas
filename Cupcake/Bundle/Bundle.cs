namespace Bundle
{
    public class Bundle : IBundlelisable
    {
        private List<IBundlelisable> _children = new List<IBundlelisable>();
        
        public void Add(IBundlelisable child) {
            _children.Add(child);
        }

        public double GetPrice()
        {
            var total = 0.0;
            foreach (var child in _children)
            {
                total += child.GetPrice();
            }
            return total;
        }

        public override string ToString()
        {
            var res = "Bundle [ ";
            var lastChild = _children.Last(); 
            foreach (var child in _children)
            {
                res += child.ToString();
                if (!child.Equals(lastChild))
                {
                    res += ", ";
                }
                else
                {
                    res += " ]";
                }
            }
            return res;
        }
    }
}