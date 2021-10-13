using System.Collections.Generic;
using Models;

namespace Assignment1DNP.Data
{
    public interface IAdultData
    {
        IList<Adult> getAdults();
        void AddAdult(Adult adult);

        void RemoveAdult(int adultId);
        void Update(Adult adult);
        Adult Get(int id);
    }
}