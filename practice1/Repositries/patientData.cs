using Microsoft.AspNetCore.Mvc;
using practice1.Data;
using Microsoft.EntityFrameworkCore;
using practice1.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace practice1.Repositries
{
    public class patientData : ControllerBase, IpatientInterface
    {
        private readonly practice1Context _context;
        public patientData(practice1Context context)
        {
            _context = context;
        }


        //Get
        public async Task<ActionResult<IEnumerable<Patient>>> GetProducts1()
        {
            return await _context.Patient.ToListAsync();
        }
        //Get by Id

        public async Task<ActionResult<Patient>> GetPatientData(int id)
        {
            var Patient = await _context.Patient.FindAsync(id);

            if (Patient == null)
            {
                return NotFound();
            }

            return Patient;
        }

        //post
        public async Task<ActionResult<Patient>> PostPatientData(Patient patientData)
        {
            _context.Patient.Add(patientData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentsData", new { id = patientData.patientId }, patientData);
        }
        //put method
        public async Task<IActionResult> PutPatientData(int id, Patient patientData)
        {
            if (id != patientData.patientId)
            {
                return BadRequest();
            }

            _context.Entry(patientData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        public async Task<IActionResult> DeletePatientData(int id)
        {

            var patientData = await _context.Patient.FindAsync(id);
            if (patientData == null)
            {
                return NotFound();
            }

            _context.Patient.Remove(patientData);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool PatientDataExists(int id)
        {
            return _context.Patient.Any(e => e.patientId == id);
        }

        //Get all tables

        public async Task<ActionResult<IEnumerable<productInformation>>> GetProducts2()
        {
            //Linq using multiple tables
            var productList = (from p in _context.Patient
                              join pm in _context.ModelInfo on p.patientId equals pm.ModelId
                              join pd in _context.ProductData on p.patientId equals pd.ProductId
                              select new productInformation()
                              {
                                  patientId=p.patientId,
                                  patientName =p.patientName,
                                  patientAge =p.patientAge,
                                  ModelName =pm.ModelName,
                                  ProductDescription =pd.ProductDescription,
                                 ProductCategory =pd.ProductCategory
                              }).ToList();
            return productList;
            //return await _context.Patient.ToListAsync();
        }
    }
}
