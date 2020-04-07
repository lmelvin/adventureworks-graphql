using System;
using System.Collections.Generic;

namespace AdventureWorks.GraphQL.App.Models
{
    public partial class EmployeeDemo
    {
        public int EmployeeId { get; set; }
        public string LoginId { get; set; }
        public int? ManagerId { get; set; }
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }
    }
}
