using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoolApi.Controllers {
    [ApiController]
    [Route ("api/role")]
    public class RestaurantController : Controller {
        private RestaurantContext _RestaurantContext;
        public RestaurantController (RestaurantContext context) {
            _RestaurantContext = context;
        }

        [HttpGet]
        public IEnumerable<Role> GetRoles () {
            return _RestaurantContext.tbl_role.ToList ();
        }

        [HttpGet ("user")]
        public IEnumerable<User> GetUsers () {
            return _RestaurantContext.tbl_user.ToList ();
        
        }

    }
}