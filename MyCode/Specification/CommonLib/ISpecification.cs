using System;

namespace CommonLib
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
