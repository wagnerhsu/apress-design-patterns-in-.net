using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib
{
    public class LineFilter : IFilter<string>
    {
        public IEnumerable<string> Filter(IEnumerable<string> items, ISpecification<string> specification)
        {
            foreach(var item in items)
            {
                if (specification.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
