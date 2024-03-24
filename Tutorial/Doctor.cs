using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Doctor
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string specialization { get; set; }
        public int Age {  get; set; }

        public Doctor() 
        {
            
        }

        public Doctor(string aname, int aid, string aspecialization)
        {
            this.Name = aname;
            this.Id = aid;
            this.specialization = aspecialization;
        }

    }

}
