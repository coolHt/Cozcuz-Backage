using System;
using System.Collections.Generic;
using ht_project.Models;
using Microsoft.AspNetCore.Mvc; //需要引用Models
namespace ht_project.Controllers {
  [Route ("api/[controller]")] //设置路由
  [ApiController]
  public class UserController : ControllerBase //请求路径api/user
  {
    [HttpPost]
    public string Post(UserTemp m){ //post方式请求
      return "value";
    }
  }
}