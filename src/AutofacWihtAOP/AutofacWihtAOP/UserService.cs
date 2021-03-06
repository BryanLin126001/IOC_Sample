﻿using System;
using Autofac.Extras.DynamicProxy;

namespace AutofacWithAOP
{
    [Intercept(typeof(CacheInterceptor))]
    [Intercept(typeof(LogInterceptor))]
    public class UserService:IUserService
    {
        public virtual void ModifyUserInfo(UserModel model)
        {
            Console.WriteLine("UserService Value");
        }
    }
}