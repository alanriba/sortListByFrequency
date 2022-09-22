using System;
using System.Linq;
using System.Threading.Tasks;
using Encora.Contracts;

namespace Encora.Business
{
    public class StringBusiness: IStringBusiness
    {
       public Task<string> GetStringSortingOperations(string param)
        {
            char[] tempArray = param.ToCharArray();

            var res = tempArray.OrderByDescending(n =>
                       tempArray.Count(x => x == n)).ThenBy(n => n);

            return Task.FromResult(string.Join("", res));
        }
    }
}

