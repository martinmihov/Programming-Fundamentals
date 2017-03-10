using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Book_Library
{
    public class Car
    {
        private String name;
        private String model;

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.model = "lada";
            this.name = this.model + "_" + name;
        }
    }
}
