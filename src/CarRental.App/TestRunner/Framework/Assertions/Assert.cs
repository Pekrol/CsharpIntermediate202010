using System;
using System.Collections.Generic;
using TestRunner.Framework.Exceptions;

namespace TestRunner.Framework.Assertions
{
    public static class Assert
    {
        public static void True<T>(this T testObject, Predicate<T> checkFunc)
        {
            True(checkFunc.Invoke(testObject));
        }

        public static void True(bool condition)
        {
            if(!condition)
            {
                throw new TestFailedException();
            }
        }
    }

    //public class CRUDOperator<T> where T : ICloneable
    //{
    //    private List<T> _items = new List<T>();

    //    public void Add(T itemToAdd)
    //    {
    //        _items.Add(itemToAdd);
    //    }

    //    public void Delete(T itemToDelete)
    //    {
    //        _items.Remove(itemToDelete);
    //    }

    //    public IEnumerable<T> List => _items;
    //}
}
