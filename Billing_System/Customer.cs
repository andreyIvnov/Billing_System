using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Billing_System
{
    [DebuggerDisplay("{Name}")]
    abstract class Customer : IComparable<Customer>, IFormattable
    {
        public string Name { get; protected set; }
        public double Balance { get; protected set; }
        private readonly int _id;
        protected static int _idCoun;

        #region Constractors
        public Customer(string name)
        {
            Name = name;
            _id = ++_idCoun;
            Balance = 0;
        }
        public Customer(string name, int balance)
        {
            Name = name;
            Balance = balance;
            _id = ++_idCoun;
        }
        #endregion

        public int ID
        {
            get
            {
                return _id;
            }
        }
        
        public abstract void AddToBalance(double amount);  //abstruct method

        public override string ToString()
        {
            return String.Format("Name: {0}\tBalance: {1}\tId Number: {2}\n", Name, Balance, _id.ToString("D9"));
        }

        public int CompareTo(Customer cus)
        {
            if (this is VIPCustomer)
            {
                return -1;
            }
            else
                return  1;
        }

        #region IFormattable interface
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                return ToString();
            switch (format)
            {
                case "name":
                    return String.Format("Name: {0}",Name);
                case "balance":
                    return String.Format("Balance: {0}", Balance);
                case "id":
                    return String.Format("ID: {0}", ID);
                default:
                    return ToString();
            }
        }
        #endregion 
    }
}
