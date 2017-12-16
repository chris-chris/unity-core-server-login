using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreServer.Models;

namespace DotnetCoreServer.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        IUserDao userDao;

        public UserController(IUserDao userDao){
            this.userDao = userDao;
        }

        [HttpGet]
        public UserResult Info(long UserID){

            UserResult result = new UserResult();
            result.Data = userDao.GetUser(UserID);
            return result;

        }

        [HttpPost]
        public UserResult Update([FromBody] User requestUser){

            UserResult result = new UserResult();
            userDao.UpdateUser(requestUser);
            
            result.Data = userDao.GetUser(requestUser.UserID);

            result.ResultCode = 1;
            result.Message = "Success";

            return result;
        }

    }

}