using Microsoft.AspNetCore.Mvc;
using practice1.Model;

namespace practice1.Repositries
{
    public interface IpatientInterface
    {


        Task<ActionResult<IEnumerable<Patient>>> GetProducts1();
        Task<ActionResult<Patient>> GetPatientData(int id);
        Task<IActionResult> PutPatientData(int id, Patient patientData);
        Task<ActionResult<Patient>> PostPatientData(Patient patientData);
        Task<IActionResult> DeletePatientData(int id);
        Task<ActionResult<IEnumerable<productInformation>>> GetProducts2();
    }
}
