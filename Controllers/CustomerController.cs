using demo.Context;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerContext context = new CustomerContext();
        // GET: Customer
        public ActionResult Index()
        {
            CustomerContext context1 = new CustomerContext();
            return View(context1.Customers.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Customer());
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(customer);
            }
        }
        
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Customer customeredit = context.Customers.Find(Id);
            return View(customeredit);
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            Customer customerdelete = context.Customers.Find(Id);
            context.Customers.Remove(customerdelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}