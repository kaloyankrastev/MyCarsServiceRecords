using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarsServiceRecords.Models
{
    /// <summary>
    /// Class representing a car
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Car manufacturer
        /// </summary>
        public string Manufacturer { get; }

        /// <summary>
        /// Model of the car
        /// </summary>
        public string Model { get; }

        /// <summary>
        /// Year the car was produced
        /// </summary>
        public string ProductionYear { get; }

        /// <summary>
        /// Vehicle identification number 
        /// </summary>
        public string VIN { get; }

        /// <summary>
        /// Milaege of the car when bought
        /// </summary>
        public int MilaegeOnBuy { get; }

        /// <summary>
        /// Date of purchase
        /// </summary>
        public DateTime PurchaseDate { get; }

        /// <summary>
        /// Car registration number
        /// </summary>
        public string RegistrationNumber { get; }

        /// <summary>
        /// Car's service history
        /// </summary>
        public List<Service> ServiceHistory { get; }

        /// <summary>
        /// Initializes an istance of <see cref="Car"/> object
        /// </summary>
        /// <param name="manufacturer">Car manufacturer</param>
        /// <param name="model">Car model</param>
        /// <param name="productionYear">Production year of the car</param>
        /// <param name="vin">Vehicle identification number</param>
        /// <param name="milaegeOnBuy">Car milaege when it was bought</param>
        /// <param name="purchaseDate">Purchasing date</param>
        /// <param name="registrationNumber">Car regisration number</param>
        /// <param name="serviceHistory">Car's service history</param>
        public Car(
            string manufacturer,
            string model,
            string productionYear,
            string vin,
            int milaegeOnBuy,
            DateTime purchaseDate,
            string registrationNumber,
            List<Service> serviceHistory)
        {
            Manufacturer = manufacturer;
            Model = model;
            ProductionYear = productionYear;
            VIN = vin;
            MilaegeOnBuy = milaegeOnBuy;
            PurchaseDate = purchaseDate;
            RegistrationNumber = registrationNumber;
            ServiceHistory = serviceHistory;
        }
    }
}
