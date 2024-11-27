using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_InMemory_CRUD_Demo.Models;
using MVC_InMemory_CRUD_Demo.Service;
namespace MVC_InMemory_CRUD_Demo.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Customer> Customers = CustomerService.GetAll();
            return View(Customers);
        }
                [HttpGet]
 
        public IActionResult Details(int id){
            var Customer = CustomerService.GetCustomerById(id);
            return View(Customer);
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer newCustomer){
            CustomerService.AddCustomer(newCustomer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id){
            var Customer = CustomerService.GetCustomerById(id);
            return View(Customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer updatedCustomer){
            CustomerService.UpdateCustomer(updatedCustomer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id){
            CustomerService.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
    }
}