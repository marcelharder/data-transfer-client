using System.Collections.Generic;
using System.Threading.Tasks;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // [Authorize]
    public class SoaController : ControllerBase
    {
        
        private IUser _user;
        private IHospitalRepository _hos;
        private ICabgRepository _cabg;

        private IEmployeeRepository _emp;
        

        // this controller is used to fill the Soa mariadb database, with uploaded data from the spa
        public SoaController(IUser user, 
        IHospitalRepository hos,
        ICabgRepository cabg,
        IEmployeeRepository emp)
        {
          
            _user = user;
            _hos = hos;
            _emp = emp;
            _cabg = cabg;
            
        }

        [HttpPost("users")]
        public async Task<IActionResult> postUsers(List<User> userList){
            return Ok(await _user.findUser(userList));}
        [HttpPost("employees")]
        public async Task<IActionResult> postEmployees(List<Class_Employee> empList){
            return Ok(await _emp.findEmployee(empList));}
        [HttpPost("hospitals")]
        public async Task<IActionResult> postHospitals(List<Class_Hospital> hosList){
            return Ok(await _hos.findHospital(hosList));}
        [HttpPost("cabgs")]
        public async Task<IActionResult> postCABG(List<Class_CABG> hosList){
            return Ok(await _cabg.findCABG(hosList));}
        
        

    }
}