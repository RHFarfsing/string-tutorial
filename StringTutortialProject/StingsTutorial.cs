using System;
using System.Collections.Generic;
using System.Text;

namespace StringTutortialProject {
    class StingsTutorial {
        public string Firstname;
        public string Lastname;
        public StingsTutorial() {
            Firstname = "John";
            Lastname = "Farfsing";
            }
        public StingsTutorial(string firstname, string lastname) {
            Firstname = firstname;
            Lastname = lastname;
            }
        public string Fullname() {
            //Don't need the vars in the methods because we have them as properties
            //var Firstname = "Robbie";
            //var Lastname = "Farfsing";
            //var Fullname = Firstname + " " + Lastname;
            var fullname = $"{Lastname}, {Firstname}";
            return fullname;
            }
        public string Fullname2() {
            //var Firstname = "Robbie";
            //var Lastname = "Farfsing";
            var fullname = $"{Firstname}, {Lastname}";
            return fullname; 
            }
        }
    }   
