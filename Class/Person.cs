using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRoom.Class
{
    public class Person
    {
        private string name;
        private string lastname;
        private string id;
        private string major;
        private string level;
        public Person(string _name, string _lastname, string _id, string _major, string _level)
        {
            this.name = _name;
            this.lastname = _lastname;
            this.id = _id;
            this.major = _major;
            this.level = _level;
        }
        public string getName(){ return name; }
        public string getLastName(){ return lastname; }
        public string getID(){ return id; }
        public string getMajor(){ return major; }
        public string getLevel(){ return level; }
    }
}
