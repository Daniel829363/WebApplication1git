using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Models.Entity
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CustomerCompany { get; set; }
        public string ExecutionCompany { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public int ProjectManagerId { get; set; }
        public Employee ProjectManager { get; set; }
        public List<Employee> Employees { get; set; }
    }

}
