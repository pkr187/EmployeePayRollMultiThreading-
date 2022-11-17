using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Multithread
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmployeeAddedtotest()
        {
            List<EmployeeDetails> empdetails = new List<EmployeeDetails>();
            {
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "pankaj", "7898323", "Manager"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Aman", "7898323", "Hr"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Shivam", "7898323", "Technical"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Shubham", "7898323", "Admin"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Rahul", "7898323", "Fresher"));

                Employeepeyrolloperation employeepayroll = new Employeepeyrolloperation();
                employeepayroll.AddEmployeeToPayroll(empdetails);

            }
        }
    }
}
