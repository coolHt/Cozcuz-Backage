using System;
using System.IO;
using System.Collections.Generic;
using ht_project.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc; //需要引用Models
using Newtonsoft.Json;
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
    public String Get()
    {
      string strResult = string.Empty;
      StringWriter sw = new StringWriter(); //用于处理字符串的流, 基于TextWriter类
      JsonTextWriter jw = new JsonTextWriter(sw); //初始化一个使用指定的TextWriter类的JsonTextWriter类的实例, 这个指定的TextWriter类用来写入 JsonTextWeiter类方法产生的结果

      List<bk_admin> res = _memberDBContext.Set<bk_admin>().ToList();
      jw.WriteStartObject();
      jw.WritePropertyName("status");
      jw.WriteValue("ok");
      jw.WritePropertyName("msg");
      jw.WriteStartArray();
      //如果数据大于0, 则创建数组遍历出来
      if(res.Count > 0){
        foreach(var item in res){
          jw.WriteStartObject();
          jw.WritePropertyName("name");
          jw.WriteValue(item.Name);
          jw.WritePropertyName("email");
          jw.WriteValue(item.Email);
          jw.WriteEndObject();
        }
      }
      jw.WriteEndArray();
      jw.WriteEndObject();
      strResult = sw.ToString();
      return strResult;
    }
  }

}