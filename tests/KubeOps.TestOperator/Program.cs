﻿using System.Threading.Tasks;
using k8s.Models;
using KubeOps.Operator;
using KubeOps.Operator.Rbac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace KubeOps.TestOperator
{
    public static class Program
    {
        public static Task<int> Main(string[] args) => CreateHostBuilder(args).Build().RunOperator(args);

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
