﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMIEmployee { get; set; }
    }
}
