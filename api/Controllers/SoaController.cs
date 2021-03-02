using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.data;
using api.DAL.dtos;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class SoaController : ControllerBase
    {
        private readonly IConfiguration _config;
        private IUser _user;
        private SpecialMaps _special;

        // this controller is used to fill the Soa mariadb database, with uploaded data from the spa
        public SoaController(IConfiguration config, IUser user, SpecialMaps special)
        {
            _config = config;
            _user = user;
            _special = special;
        }
        [HttpPost] // post the user to mariadb, add if does not exist
        [Route("api/updateSoaUser")]
        public async Task<IActionResult> GetAsync1(UserForUpdateDto u)
        {
            if(_user.getUserDetails(u.Id) == null){
                var help = new User();
                _user.Add(help);
                if(await _user.SaveAll()){
                    var new_user = await _user.getUserDetails(help.Id);
                    _user.Update(_special.mapToUserAsync(u, new_user));
                }
            }
            else{
                 var existing_user = await _user.getUserDetails(u.Id);
                    _user.Update(_special.mapToUserAsync(u, existing_user));
            }
            return Ok();
        }

    }
}