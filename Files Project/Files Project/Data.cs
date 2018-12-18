using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Project
{
    class Data
    {
        string name;
        string id;
        string gender;
        string salary;

        public Data(string id, string name, string gender, string salary)
        {
            this.gender = gender;
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
    }
}
