using System;

namespace StudentClassProject {
    class Program {
        static void Main(string[] args) {
            var Lidya = new Student();
            Lidya.Firstname = "Lidya";
            Lidya.Lasttname = "Tsegay";
            Lidya.SetFinalGrade(98);
            var fullname = Lidya.GetFullname();
            Console.WriteLine("Lidya's full name is " + fullname);

            var Justin = new Student();
            Justin.Firstname = "Justin";
            Justin.Lasttname = "Dudley";
            Justin.SetFinalGrade(99);
            fullname = Justin.GetFullname();
            Console.WriteLine($"{fullname}");

            var Nick = new Student();
            Nick.Firstname = "Nick";
            Nick.Lasttname = "Baker";
            Nick.SetFinalGrade(97);
            fullname = Nick.GetFullname();
            Console.WriteLine($"{Nick.Firstname} {Nick.Lasttname}");
            

        }
    }
}
