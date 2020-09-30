using System;
using System.Collections.Generic;

// ViewModel: Helps display all skills in employee skill editing screen

namespace IndeavorTest.Models {
    public class ViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<Skill> Skills { get; set; }
    }
}