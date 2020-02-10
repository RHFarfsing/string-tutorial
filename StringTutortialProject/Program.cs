using System;

namespace StringTutortialProject {
    class Program {
        static void Main(string[] args) {
            var st1 = new StingsTutorial();
            var fullname = st1.Fullname();
            Console.WriteLine($"Fullname is {fullname}.");
            Console.WriteLine($"Fullname2 is {st1.Fullname2()}.");
            var denise = new StingsTutorial("Denise", "Barktick");
            Console.WriteLine($"Denise {denise.Fullname()}");
            Console.WriteLine($"Denise {denise.Fullname2()}");
            }
        }
    }