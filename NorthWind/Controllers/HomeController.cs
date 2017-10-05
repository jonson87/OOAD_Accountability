using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Models;
using NorthWind.Data;

namespace NorthWind.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _newContext;
        private NORTHWNDContext _oldContext;
        public HomeController(ApplicationDbContext newContext, NORTHWNDContext oldContext)
        {
            _newContext = newContext;
            _oldContext = oldContext;
        }
        public IActionResult Index()
        {
            var supList = _oldContext.Suppliers.ToList();
            var empList = _oldContext.Employees.ToList();
            var custList = _oldContext.Customers.ToList();
            var shippersList = _oldContext.Shippers.ToList();
            var orders = _oldContext.Orders.ToList();

            foreach (var sup in supList)
            {
                var party = new Party
                {
                    Name = sup.ContactName
                };
                _newContext.Parties.Add(party);
                _newContext.SaveChanges();
            }

            foreach (var sup in empList)
            {
                var party = new Party
                {
                    Name = sup.FirstName + " " + sup.LastName
                };
                _newContext.Parties.Add(party);
                _newContext.SaveChanges();
            }
            foreach (var sup in custList)
            {
                var party = new Party
                {
                    Name = sup.CompanyName
                };
                _newContext.Parties.Add(party);
                _newContext.SaveChanges();
            }


            
            //foreach (var sup in supList)
            //{
            //    var person = new Person
            //    {
            //        FirstName = sup.ContactName.Substring(0, sup.ContactName.IndexOf(" ")),
            //        LastName = sup.ContactName.Substring(sup.ContactName.IndexOf(" ")+1)
            //    };
            //    _newContext.Persons.Add(person);
            //    _newContext.SaveChanges();
            //    var organization = new Organization
            //    {
            //        Address = sup.Address,
            //        City = sup.City,
            //        Phone = sup.Phone,
            //        ZipCode = sup.PostalCode,
            //        Fax = sup.Fax,
            //        HomePage = sup.HomePage,
            //        OrganizationName = sup.CompanyName,
            //        Region = sup.Region,
            //        Person = person,
            //        PersonId = person.PersonID
            //    };
            //    _newContext.Organizations.Add(organization);
            //    _newContext.SaveChanges();
            //}
            //foreach (var emp in empList)
            //{
            //    var person = new Person
            //    {
            //        Address = emp.Address,
            //        BirthDate = emp.BirthDate,
            //        City = emp.City,
            //        FirstName = emp.FirstName,
            //        LastName = emp.LastName,
            //        EmployeeReportsTo = emp.ReportsTo,
            //        Extension = emp.Extension,
            //        HireDate = emp.HireDate,
            //        Notes = emp.Notes,
            //        Phone = emp.HomePhone,
            //        Photo = emp.Photo,
            //        PhotoPath = emp.PhotoPath,
            //        Region = emp.Region,
            //        Title = emp.Title,
            //        ZipCode = emp.PostalCode,
            //        TitleOfCourtesy = emp.TitleOfCourtesy
            //    };
            //    _newContext.Persons.Add(person);
            //    _newContext.SaveChanges();
            //}
            //foreach (var cust in custList)
            //{
            //    Organization organization = null;
            //    if (!String.IsNullOrEmpty(cust.CompanyName))
            //    {
            //        organization = new Organization
            //        {
            //            OrganizationName = cust.CompanyName,
            //            Address = cust.Address,
            //            City = cust.City,
            //            Phone = cust.Phone,
            //            Region = cust.Region,
            //            ZipCode = cust.PostalCode
            //        };
            //        _newContext.Organizations.Add(organization);
            //        _newContext.SaveChanges();
            //    }
            //    var person = new Person
            //    {
            //        Address = cust.Address,
            //        City = cust.City,
            //        Region = cust.Region,
            //        ZipCode = cust.PostalCode,
            //        Phone = cust.Phone,
            //        Title = cust.ContactTitle
            //    };

            //    _newContext.Persons.Add(person);
            //    _newContext.SaveChanges();

            //    if (organization != null)
            //    {
            //        organization.Person = person;
            //        _newContext.Update(organization);
            //        person.Organization = organization;
            //        _newContext.Update(person);
            //        _newContext.SaveChanges();
            //    }
            //}
            //Test
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
