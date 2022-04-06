using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HospitalMachineTest.Models
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly SqlDbContext db = new SqlDbContext();
        public async Task Add(Hospital hospital)
        {
            hospital.Id = Guid.NewGuid().ToString();
            db.Hospitals.Add(hospital);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<Hospital> GetHospital(string id)
        {
            try
            {
                Hospital hospital = await db.Hospitals.FindAsync(id);
                if (hospital == null)
                {
                    return null;
                }
                return hospital;
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Hospital>> GetHospitals()
        {
            try
            {
                var hospitals = await db.Hospitals.ToListAsync();
                return hospitals.AsQueryable();
            }
            catch
            {
                throw;
            }
        }
    }
}