using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRoom.Class
{
    public class Students
    {
        private Person person;
        private string datein;
        public Students(Person person, string datein)
        {
            this.person = person;
            this.datein = datein;
        }
        public Person getPerson() { return person; }
        public string getDatein() { return datein; }
    }
}
