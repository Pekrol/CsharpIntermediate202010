using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{

    /// <summary>
    /// Clitent class 
    /// </summary>
    public class Client
    {

        #region  Properties

        /// <summary>
        /// Initalize for incrementation of ID 
        /// </summary>
        private static int idIncrement = 0;
        /// <summary>
        /// Id property
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name property
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname property
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Adult boolean property
        /// </summary>
        public bool Adult { get; set; }
        /// <summary>
        /// Found property
        /// </summary>
        private double Capital { get; set; }
        #endregion


        /// <summary>
        /// Client constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="adult"></param>
        #region Constructor
        public Client(string name, string surname, bool adult)
        {
            idIncrement++;
            this.Id = idIncrement;
            this.Name = name;
            this.Surname = surname;
            this.Adult = adult;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Add additional money to client founds
        /// </summary>
        /// <param name="money"></param>
        public void AddFounds(double money)
        {
            Capital += money;
        }

        /// <summary>
        /// Make payment
        /// </summary>
        /// <param name="price"></param>
        public void MakePayment(double price)
        {
            Capital -= price;
        }

        /// <summary>
        /// Show clients $$$$$
        /// </summary>
        public void ShowClientsCapital()
        {
            Console.WriteLine($"Clients capital: {Capital}");
        }
        #endregion
    }
}