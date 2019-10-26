using System;
using System.Collections.Generic;
using ht_project.Models;
using Microsoft.AspNetCore.Mvc; //需要引用Models
namespace ht_project.Controllers {
  [Route ("api/[controller]")] //设置路由
  [ApiController]
  public class UserController : ControllerBase //请求路径api/user
  {
    private readonly User _context;
    //构造函数赋model
    public UserController (User context) { //
      _context = context;
    }

    [HttpPost]
    public ActionResult<IEnumerable<string>> Get () {
      //Console.Write (_context);
      return new string[] { "value1", "value2" };
    }
  }
}