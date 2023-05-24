﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Infrastructure.Utils {
    public static class ApplicationServiceRegistration {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) {
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());    
            return services;
        }
    }
}
