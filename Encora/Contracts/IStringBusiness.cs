using System;
using System.Threading.Tasks;

namespace Encora.Contracts
{
    public interface IStringBusiness
    {
        Task<String> GetStringSortedFrequency(string param);
    }
}

