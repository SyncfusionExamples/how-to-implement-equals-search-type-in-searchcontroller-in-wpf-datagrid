using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        int unitPrice;

        [Display(Name = "Order ID")]
        public int OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }

        [Display(Name = "Customer ID")]
        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }

        [Display(Name = "Customer Name")]
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        [Display(Name = "Country")]
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        [Display(Name = "Unit Price")]
        public int UnitPrice
        {
            get { return unitPrice; }
            set
            {
                unitPrice = value;
                OnPropertyChanged("Salary");
            }
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, int unitPrice)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.UnitPrice = unitPrice;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

      
    

