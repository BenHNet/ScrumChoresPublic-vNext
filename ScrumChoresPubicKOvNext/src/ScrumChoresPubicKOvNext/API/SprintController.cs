using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity;
using ScrumChoresPubicKOvNext.Models;
using ScrumChores.Model.Interfaces;
using ScrumChores.Business.Repositories;
using Microsoft.AspNet.Identity.EntityFramework;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumChoresPubicKOvNext.API.Controllers
{    
    [Route("api/[controller]")]
    public class SprintController : Controller
    {


        private ISprintRepository _sprintRepo;
        private IUserRepository _userRepo;
        private UserManager<ApplicationUser> _userManager;

        public SprintController()
            : this(new SprintRepository(), new UserRepository(), new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
        {
        }

        public SprintController(ISprintRepository repoSprint, IUserRepository repoUser, UserManager<ApplicationUser> userManager)
        {
            _sprintRepo = repoSprint;
            _userRepo = repoUser;
            _userManager = userManager;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
