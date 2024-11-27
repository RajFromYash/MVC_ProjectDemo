using System.Collections.Generic;
using MVC_InMemory_CRUD_Demo.Models;


namespace MVC_InMemory_CRUD_Demo{
    public class CustomerService
    {
        public static List<Customer> Customers;
        public static int nextId=105;

        static CustomerService(){
            Customers = new List<Customer>
            {
                new Customer { CustomerId = 101, Name = "John Doe", Address="Ek street noida",DOB = new System.DateTime(2003, 5, 18), PAN_Number= "CbyPt1231L"},
                new Customer { CustomerId = 102, Name = "Jane Doe", Address="Gulab street delhi", DOB = new System.DateTime(2003, 7, 18), PAN_Number= "CbyPt4567M"},
                new Customer { CustomerId = 103, Name = "Alice Doe", Address="Park street mumbai", DOB = new System.DateTime(2013, 5, 18),PAN_Number= "CbyPa112231L"},
                new Customer { CustomerId = 104, Name = "Bob Doe", Address="Sunset street bangalore", DOB = new System.DateTime(2003, 11, 28), PAN_Number= "CbyPt9876M"},
                new Customer { CustomerId = 105, Name = "Charlie Doe", Address="Pine street chennai", DOB = new System.DateTime(2006, 7, 28),PAN_Number= "Cbyasd1231"},
                new Customer { CustomerId = 106, Name = "David Doe", Address="River street hyderabad",DOB = new System.DateTime(2008, 8, 8), PAN_Number= "CbyPt7890M"},
                new Customer { CustomerId = 107, Name = "Emma Doe", Address="Oak street kolkata", DOB = new System.DateTime(2000, 12, 1),PAN_Number="CbyPt78"},
            };
        }

        public static List<Customer> GetAll(){
            return Customers;
        }

        public static Customer GetCustomerById(int id){
            return Customers.Find(c=>c.CustomerId==id);
        }

        public static  void AddCustomer(Customer customer){
            customer.CustomerId=nextId;
            Customers.Add(customer);
            nextId++;
        }

        public static void UpdateCustomer(Customer modified){
            int index = Customers.FindIndex(m=>m.CustomerId == modified.CustomerId);
            if(index==-1)return;
            else Customers[index]=modified;
        }

        public static void DeleteCustomer(int id){
            Customers.RemoveAll(m=>m.CustomerId == id);
        }

    }
}