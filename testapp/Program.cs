using System;

namespace Testapp {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("Console writeLine test");
            Console.WriteLine("Moar lines");
            Console.ReadKey();
            var u = "test";
            UnityEngine.AnisotropicFiltering anisoTest = UnityEngine.AnisotropicFiltering.ForceEnable;
            if (anisoTest.Equals(UnityEngine.AnisotropicFiltering.ForceEnable)) {
                Console.WriteLine("Aniso enabled");
                Console.WriteLine(u);
            }
        }
    }
}
