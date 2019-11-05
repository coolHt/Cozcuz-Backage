using System;
using System.Collections.Generic;
using ht_project.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc; //需要引用Models
namespace ht_project.Controllers {
  [Route ("api/[controller]")] //设置路由
  [ApiController]
  public class UserController : ControllerBase //请求路径api/user
  {

    private readonly MemberDBContext _memberDBContext;

    public UserController(MemberDBContext memberDBContext)
    {
      _memberDBContext = memberDBContext;
    }

    [HttpPost]
    public string Post(UserTemp m){ //post方式请求
      return "value";
    }
    [HttpGet]
    public List<bk_admin> Get()
    {
      // using (MemberDBContext _coreDbContext = new MemberDBContext())
      // {
      //   return _coreDbContext.Set<bk_admin>().ToList();
      // }
      return _memberDBContext.Set<bk_admin>().ToList();
    }
  }

}