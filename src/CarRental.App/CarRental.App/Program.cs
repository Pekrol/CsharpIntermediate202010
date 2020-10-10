using CarRental.Bussiness.Cars;
using CarRental.Bussiness.Reservations;
using CarRental.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CarRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicesProvider = ConfigureServices().BuildServiceProvider();

            //var carRepository = new CarRepository();
            var reservationModule = servicesProvider.GetService<IReservationModule>();
            reservationModule.ReserveCarFromSegment(Segment.Family, DateTime.Now, DateTime.Now.AddDays(4));

            // reservationmodule.Re           
        }

        static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build() ;

            services.AddSingleton(config);
            services.AddSingleton<ICarRepository, CarRepository>();
            services.AddSingleton<IReservationModule, ReservationModule>();
            

            return services;
        }
    }
}
