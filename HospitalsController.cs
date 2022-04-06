using HospitalMachineTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HospitalMachineTest.Controllers
{
    public class HospitalsController : Controller
    {

        private readonly IHospitalRepository _iHospitalRepository = new HospitalRepository();

        [HttpGet]
        [Route("api/Hospitals/Get")]
        public async Task<IEnumerable<Hospital>> Get()
        {
            return await _iHospitalRepository.GetHospitals();
        }

        [HttpGet]
        [Route("api/Hospitals/Details/{id}")]
        public async Task<Hospital> Details(string id)
        {
            var result = await _iHospitalRepository.GetHospital(id);
            return result;
        }
        // GET: Hospitals
        public ActionResult Index()
        {
            return View();
        }


    }
}