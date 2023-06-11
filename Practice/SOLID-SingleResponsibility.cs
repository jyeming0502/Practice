using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }

        public int Price { get; set; }

        public Book(string name, string authorName, int year, int price)
        {
            Name = name;
            AuthorName = authorName;
            Year = year;
            Price = price;
        }   
    }

    public class Invoice
    {
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        //private double total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate)
        {
            this.book = book;
            this.quantity = quantity;
            this.discountRate = discountRate;
            this.taxRate = taxRate;
        }

        //public double CalculateTotal()
        //{
        //    double price = (book.Price - book.Price * discountRate) * this.quantity);
        //    double priceWithTaxes = price * (1+taxRate);
        //    return priceWithTaxes;
        //}
    }
}
