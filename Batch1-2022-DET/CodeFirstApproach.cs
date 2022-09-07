using Batch1_2022_DET.Data;
using Batch1_2022_DET.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_2022_DET
{
    public class CodeFirstApproach
    {
        public static void Main(string[] args)
        {
            //AddNewBook();
            //RemoveBook();
            //UpdateBook();
            //GetAll();
            //AddOrder();
            //AddNewCustNOrder();
            //GetAllCustomersWithOrder_ExplicitLoading();
            //GetAllCustomersWithOrder_EagerLoading();

            Disconnectedarchitecture();


            Console.ReadLine();
        }
        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 6;
        //    book.BookName = "Confidence";
        //    book.author = "Donna";
        //    book.price = 289;

        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Book Added");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException.Message);

        //    }
        //}

        //private static void RemoveBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 2;
        //    book.BookName = "API";
        //    book.author = "Harvey Spectre";
        //    book.price = 270;

        //    try
        //    {
        //        ctx.Book.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("EF CORE removed");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException.Message);

        //    }
        //}

        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Book.Where(b => b.BookID == 3).SingleOrDefault();
        //    //Book book = new Book();
        //    //book.BookID = 3;
        //    //book.BookName = "LINQ";
        //    //book.author = "Harvey Spectre";
        //    //book.price = 270;

        //    try
        //    {
        //        Books.BookName = "SQL";
        //        ctx.Book.Update(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Updated");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException.Message);

        //    }
        //}
        //private static void RemoveBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Book.Where(b => b.BookID == 4).SingleOrDefault();
        //    //Book book = new Book();
        //    //book.BookID = 3;
        //    //book.BookName = "LINQ";
        //    //book.author = "Harvey Spectre";
        //    //book.price = 270;

        //    try
        //    {

        //        ctx.Book.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Removed");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException.Message);

        //    }
        //}
        //private static void GetAll()             //This calls stored procedure without parameters.
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Book;



        //    foreach (var b in Books)
        //    {
        //        Console.WriteLine(b.BookName + " ");
        //    }
        //}
        //private static void AddNewCustNOrder()
        //{
        //    var ctx = new BookContext();
        //    Customer customer = new Customer();
        //    customer.ID = 1357;
        //    customer.Name = "Geller";
        //    customer.Age = 32;

        //    Order ord = new Order();
        //    ord.Order_ID = 1974;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;
        //}
        //    private static void AddOrder()
        //     {
        //            var ctx = new BookContext();
        //            var order = ctx.Customers.Where(e => e.Customer_ID == 1357).SingleOrDefault();
        //            try
        //         {

        //        Order ord = new Order();

        //        ord.Order_ID = 1969;
        //        ctx.Update(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Updated");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //List<Order> MyOrders = new List<Order>();
        //MyOrders.Add(ord);
        //customer.Orders = MyOrders;



        //ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and Order is created!");
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //private static void GetAllCustomersWithOrder_EagerLoading()
        //{
        //    //Eager loading means that the related data is loaded
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);                   



        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");




        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //private static void GetAllCustomersWithOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;



        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");



        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());



        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        private static void Disconnectedarchitecture()    //Disconnected Architecture
        {
            var ctx = new BookContext();



            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();



            ctx.Dispose();



            UpdateCustomerName(customer);



        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR



            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");



        }
    }
    }
    

    
        




        
    

    



