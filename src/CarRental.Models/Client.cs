using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{
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
        public int id { get; set; }
        /// <summary>
        /// Name property
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Surname property
        /// </summary>
        public string surname { get; set; }
        /// <summary>
        /// Age property
        /// </summary>
        public bool adult { get; set; }
        /// <summary>
        /// Found property
        /// </summary>
        private double capital { get; set; }
        #endregion


        /// <summary>
        /// Client constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="adult"></param>
        #region Constructor
        public Client(string name,string surname,bool adult)
        {
            idIncrement++;
            this.id = idIncrement;
            this.name = name;
            this.surname = surname;
            this.adult = adult;
        }
        #endregion

        #region Methods
        
        /// <summary>
        /// Add additional money to client founds
        /// </summary>
        /// <param name="money"></param>
        public void AddFounds(double money)
        {
            capital += money;
        }

        /// <summary>
        /// Make payment
        /// </summary>
        /// <param name="price"></param>
        public void makePayment(double price)
        {
            capital -= price;
        }

        #endregion
    }
}
