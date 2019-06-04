using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib
{
    public class StartWithSpecification : ISpecification<string>
    {
        string _prefix;
        public StartWithSpecification(string prefix)
        {
            _prefix = prefix;
        }
        public bool IsSatisfied(string t)
        {
            return t.StartsWith(_prefix);
        }
    }
}
