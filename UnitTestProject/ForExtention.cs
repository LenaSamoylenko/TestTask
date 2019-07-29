using System.Collections.Generic;
using TestProject;


namespace UnitTestProject
{
    public static class ForExtention
    {
        public static bool IsInCollection(this IEnumerable<IStoreable> st, IStoreable obj)
        {
            bool result = false;

            foreach (var item in st)
            {
                if (item.Equals(obj))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}


