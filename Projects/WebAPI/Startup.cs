using Autofac;
using Data.Services;
using Microsoft.AspNetCore.Authentication;
using System.ComponentModel;

namespace WebAPI
{

    public static class Startups
    {
        public static Autofac.IContainer Container { get; set; }

        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Data.BaseContext>().AsSelf();
            builder.RegisterType<RoleService>().AsImplementedInterfaces();
            builder.RegisterType<UserService>().AsImplementedInterfaces();

            Container = builder.Build();
        }
    }
}