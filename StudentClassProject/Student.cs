using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassProject {

    class Student { //Class and Name

        public string Firstname { get; set; } //Properties
        public string Lasttname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } // "public" is an access modifier
        public int FinalGrade { get; set; }

        public string GetFullname() {
            return Firstname + " " + Lasttname;
        }

        public void SetFinalGrade(int finalgrade) { //if method doesn't return anything, make sure you have void for type
            if (finalgrade < 0) {
                Console.WriteLine("ERROR: grade must be greater than zero");
            }
            else {
                FinalGrade = finalgrade;
            }
        }


    }
}
