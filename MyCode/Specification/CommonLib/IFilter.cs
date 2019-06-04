using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }
}
