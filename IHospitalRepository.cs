using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HospitalMachineTest.Models
{
    public interface IHospitalRepository
    {
        Task Add(Hospital hospital);
        Task<Hospital> GetHospital(string id);
        Task<IEnumerable<Hospital>> GetHospitals();
    }
}