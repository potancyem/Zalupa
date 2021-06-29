using System;

namespace YaSdelal {
    class Program {
        public static bool IsSimple(int a) {
            int counter = 0;
            for (int i = 1; i <= a; i++) {
                
                if (a % i == 0) {
                    counter++;
                }
               
                
            }
             if (counter == 2) {
                    return true;
                    counter = 0;
                } 
            return false;
            
        }
        static void Main(string[] args) {
            
            int a = 1000;
            for (int i = 0; i <= a; i++) {
                
                if (IsSimple(i) == true) {
                    Console.WriteLine(i + "Простое число");
                }
            }
        }
    }
}
