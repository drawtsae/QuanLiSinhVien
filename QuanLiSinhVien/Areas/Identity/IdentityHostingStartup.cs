﻿using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(QuanLiSinhVien.Areas.Identity.IdentityHostingStartup))]
namespace QuanLiSinhVien.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}