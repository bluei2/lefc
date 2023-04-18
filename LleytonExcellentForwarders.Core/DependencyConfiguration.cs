using System;
using Microsoft.Extensions.DependencyInjection;
using LleytonExcellentForwarders.Interface;
using LleytonExcellentForwarders.Service;

namespace LleytonExcellentForwarders.Core
{
    public static class DependencyConfiguration{
        public static void ConfigureApplicationServices(this IServiceCollection services){
            services.AddTransient<ICustomerService,      CustomerService>();
            services.AddTransient<IEmployeeService,      EmployeeService>();
            services.AddTransient<IFreightService,       FreightService>();
            services.AddTransient<IFuelService,          FuelService>();
            services.AddTransient<IOrganizationService,  OrganizationService>();
            services.AddTransient<IPayrollService,       PayrollService>();
            services.AddTransient<IRateService,          RateService>();
            services.AddTransient<IRoleService,          RoleService>();
            services.AddTransient<IRouteService,         RouteService>();
            services.AddTransient<ISalaryService,        SalaryService>();
            services.AddTransient<IShipmentService,      ShipmentService>();
            services.AddTransient<ITransactionService,   TransactionService>();
            services.AddTransient<ITypeService,          TypeService>();
            services.AddTransient<IVehicleService,       VehicleService>();
            services.AddTransient<IVendorService,        VendorService>();
            services.AddTransient<IWageService,          WageService>();

        }

    }
}