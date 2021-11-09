using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Billing_System
{
    class BillingSystem 
    {
        public delegate void BalanceExceededEventHandler(object sender, BalanceExceededEventArgs arg);      //Event example
        public event BalanceExceededEventHandler BalanceExceeded;                                           //Event example

        const int _defaultSize = 100;
        List<Customer> _customers; /*Customer[]*/
        public int _numOfCustomers { get; private set; }

        #region Constructors
        public BillingSystem(int size)
        {
            BalanceExceeded += BillingSystem_BalanceExceeded;
            _customers =new List<Customer>(size); /*new Customer[size];*/
        }
        public BillingSystem() : this(_defaultSize) { }

        #endregion Construnctors

        #region Local Methods + Events

        public void AddCustomer(Customer customer)
        {
            try
            {
                _customers.Add(customer);
                ++_numOfCustomers;
            }
            catch (IndexOutOfRangeException rang)
            {
                throw new IndexOutOfRangeException(rang.Message +"\nThe max num of customers is: " +
                    $"{_numOfCustomers}");
            }
            catch (Exception)
            {
                throw new Exception();
            }
            //}
        }
        public void UpdateBalance(double amount)
        {
            for (int i = 0; i < _numOfCustomers; ++i)
            {
                _customers[i].AddToBalance(amount);
                if (_customers[i].Balance >= 2000)
                    BalanceExceeded?.Invoke(this, new BalanceExceededEventArgs(_customers[i]));//Event exercise
            }
        }
        private void BillingSystem_BalanceExceeded(object sender, BalanceExceededEventArgs arg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dear {arg._name} you are exceed you'r balance up to 2000 and now is {arg._balance}!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ChargingCalls()
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < _numOfCustomers; j++)
                {
                    _customers[j].AddToBalance(rnd.Next(1800,2600));
                    if (_customers[j].Balance >= 2000)
                        BalanceExceeded?.Invoke(this, new BalanceExceededEventArgs(_customers[j]));//Event exercise
                }
            }
        }  //Event's checker Method

        /*
        *Anther way to ADD a event 
        */
        public void SaiToAccountingClerk()
        {
            AccountingClerk ac = new AccountingClerk(this);
        }
        public void SaiToCustomerService()
        {
            CustomerService cs = new CustomerService(this);
        }

        public override string ToString()
        {
            string s = String.Empty;
            for (int i = 0; i < _numOfCustomers; ++i)
            {
                s += _customers[i];
            }
            return s;
        }

        
        #endregion Local Methods

        #region Interfaces
    public void SortByCustomerType()
    {
            _customers.Sort();
        }// IComparable<Customer>
    public void Sort(IComparer<Customer> criteria)
    {
        _customers.Sort(criteria);
    }  //IComperer sorting by criteria

    #endregion

        #region Indexers
    public Customer this[string name]             
        {
            get
            {
                //throw new NotCorrectNameException("No such name:(");
                try
                {
                    for (int i = 0; i < _customers.Count; i++)
                    {
                        if (_customers[i].Name.Equals(name))
                            return _customers[i];
                    }
                }
                catch (NullReferenceException)
                {
                    throw new NotCorrectNameException("\nNo customer with this name");
                }
                return null;
            }
        }
        public Customer this[int id, string name]   
        {
            get
            {
                for (int i = 0; i < _customers.Count; ++i)
                {
                    if (_customers[i].ID.Equals(id))
                        if (_customers[i].Name.Equals(name))
                            return _customers[i];
                        else throw new NotCorrectNameException("\nThis ID had diferent Name!");
                }
                return null;
            }
        }
        public Customer this[int index]             
        {
            get
            {
                if (index < 0 || index >= _numOfCustomers)
                    throw new IndexOutOfRangeException($"\nThere is no customer in this index\nMost be bigger the 0 and less them {_numOfCustomers}");
                return _customers[index];
            }
        }
        #endregion Indexers

        public class NotCorrectNameException : Exception
        {
            public NotCorrectNameException() { }
            public NotCorrectNameException(string message) : base(message) { }
        }
    }

}
