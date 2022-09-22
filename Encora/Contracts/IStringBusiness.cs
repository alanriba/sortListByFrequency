using System;
using System.Threading.Tasks;

namespace Encora.Contracts
{
    public interface IStringBusiness
    {
        public Task<string> GetStringSortingOperations(string param);
    }
}

