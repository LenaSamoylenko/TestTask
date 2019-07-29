using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Models
{
    public class Product : IStoreable
    {
        public IComparable Id { get; set; }
    }
}
