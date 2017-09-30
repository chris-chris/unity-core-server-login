using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreServer.Models;

namespace DotnetCoreServer.Controllers
{
    [Route("[controller]/[action]")]
    public class UpdateResultController : Controller
    {

        IUserDao userDao;
        IStageResultDao stageResultDao;
        public UpdateResultController(IUserDao userDao, IStageResultDao stageResultDao){
            this.userDao = userDao;
            this.stageResultDao = stageResultDao;
        }

        [HttpPost]
        public ResultBase Post([FromBody] StageRequest request){

            ResultBase result = new ResultBase();

            User user = userDao.GetUser(request.UserID);

            user.Point = user.Point + request.Point;

            userDao.UpdateUser(user);

            stageResultDao.InsertStageRecord(request.UserID, request.Point);

            result.ResultCode = 1;
            result.Message = "Success";

            return result;

        }


    }
}