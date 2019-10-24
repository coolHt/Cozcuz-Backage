using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ht_project.Models;

namespace ht_project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)  //IConfiguration 读取配置
    {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //执行于Configure之前, 用于配置应用的服务 
    {  //IServiceCollection 拥有add{Service}扩展方法 来新增服务
          services.AddDbContext<TodoContext>(opt =>  //这里添加一个服务，这个服务是属于DbContext的，而且是TodoContext的实例
                opt.UseInMemoryDatabase("TodoList"));  
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        //Configure 主要用于 应用响应HTTP请求的方式
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) //用于创建应用的请求管理通道 ( 添加中间件 )  IHostingEnvironment 按环境配置服务
    {   

            //use方法将一个或多个中间件组件添加到请求管道, 中间件组件用于负责调用管道中的下一个组件
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection(); 
            app.UseMvc();
        }
    }
}
