using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice1.Data;
using practice1.Model;
using practice1.Repositries;

namespace practice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly practice1Context _context;
        private readonly IpatientInterface _IpatientInterface;
        public PatientsController(practice1Context context, IpatientInterface IpatientInterface)
        {
            _context = context;
            _IpatientInterface = IpatientInterface;
        }

        // GET: api/Patients
        [HttpGet]
        [Route("GetProducts1")]
        public async Task<ActionResult<IEnumerable<Patient>>> GetProducts1()
        {
            return await _IpatientInterface.GetProducts1();
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {

            return await _IpatientInterface.GetPatientData(id);
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(int id, Patient patient)
        {
            return await _IpatientInterface.PutPatientData(id, patient);
        }

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient(Patient patient)
        {
            return await _IpatientInterface.PostPatientData(patient);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            return await _IpatientInterface.DeletePatientData(id);
        }

        [HttpGet]
        [Route("GetProducts2")]

        public  async Task<ActionResult<IEnumerable<productInformation>>> GetProducts2()
        {
            return await _IpatientInterface.GetProducts2();
        }


    }
}
