﻿using System;


namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName 
        {
            get
            {
                return LastName + "," + FirstName;
            }
        
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value; 
            }  
        }

    }
}
