using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ht_project.Controllers
{
    [Route("api/[controller]")]  //设置路由
    [ApiController]
    public class UserController : ControllerBase  //请求路径api/user
    {
      [HttpPost]
      public ActionResult<IEnumerable<string>> Get(){
        return new string[]{"value1", "value2"};
      }
    }
}