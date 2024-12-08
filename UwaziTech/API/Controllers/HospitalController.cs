using Microsoft.AspNetCore.Mvc;
using UwaziTech.API.Model.Request;
using UwaziTech.API.Model.Response;
using UwaziTech.Core.Services.Interfaces;

namespace UwaziTech.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _service;
        public HospitalController(IHospitalService service) 
        {
            _service = service;
        }

        [HttpPost("add-hospital")]
        public async Task<IActionResult> AddHospitalDetails([FromBody] HospitalRequest request, CancellationToken token)
        {
            var result = await _service.AddHospitalDetailsAsync(request, token);

            return Ok(result);
        }

        [HttpPost("add-hospital-admin")]
        public async Task<IActionResult> AddHospitalAdmin([FromBody] HospitalAdminRequest request, CancellationToken token)
        {
            var result = await _service.AddHospitalAdminAsync(request, token);

            return Ok(result);
        }

        [HttpGet("fetch-hospital-details")]
        public IActionResult FetchHospitalDetails(CancellationToken token)
        {
            var hospital_result = new List<HospitalModel>
            {
                new HospitalModel
                {
                    Address = "the address",
                    Branch = "nairobi branch",
                    HospitalName = "Mp shah"
                },
                new HospitalModel
                {
                    Address = "another address",
                    Branch = "kisumu branch",
                    HospitalName = "Aga Khan"
                },
                new HospitalModel
                {
                    Address = "yet another address",
                    Branch = "mombasa branch",
                    HospitalName = "Coast General"
                }
            };

            var hospital_admin = new List<HospitalAdminModel>
            {
                new HospitalAdminModel
                {
                    Hospital = "Mp Shah",
                    Username = "Hosp Admin",
                    Role = "Admin",
                    Password = "****"
                },
                new HospitalAdminModel
                {
                    Hospital = "Aga Khan",
                    Username = "Admin1",
                    Role = "Super Admin",
                    Password = "****"
                },
                new HospitalAdminModel
                {
                    Hospital = "Coast General",
                    Username = "Manager",
                    Role = "Manager",
                    Password = "****"
                }
            };

            var result = new FetchHospitalDetailsModel
            {
                HospitalAdmins = hospital_admin,
                HospitalModels = hospital_result
            };

            return Ok(result);
        }
    }
}
