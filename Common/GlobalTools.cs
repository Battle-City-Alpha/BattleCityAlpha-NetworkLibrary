using System.Collections.Generic;

namespace BCA.Common
{
    public static class GlobalTools
    {
        public static List<U> GetDictionnaryValues<T, U>(Dictionary<T, U> dic)
        {
            List<U> toReturn = new List<U>();
            foreach (var value in dic)
                toReturn.Add(value.Value);
            return toReturn;
        }
    }
}
