using System.Runtime.CompilerServices;
using System.Text;

namespace ITDCA_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PART 1
            string module = "ITDCA"; //stringbuilder much more efficient than string concatenation.
            string[] description = { "data", "structures", "and", "algorithms" };
            foreach (string word in description)
            {
                Console.Write(word+" ");
            }


            string hello = "";
            for (int i = 0; i < 40; i++)
            {
               hello+= "Hello! "; //inefficient string concatenation 
            }
            Console.WriteLine(hello + hello.Length);



            //PART 2
            // repeat on a larger scale
            string largeSentence = "";
            Console.WriteLine($"Hash: {RuntimeHelpers.GetHashCode(largeSentence)}"); // visually depict inefficiencies


            for (int i = 0; i < 5; i++)
            {
                largeSentence += "hello ";   // creates a new string object
                Console.WriteLine(largeSentence);
                Console.WriteLine($"Iteration {i}: Hash: {RuntimeHelpers.GetHashCode(largeSentence)} and length: {largeSentence.Length}");
            }
            // awaiting the garbage collector to clear up each string's memory...
            //new hashcodes as the string changes.
            Console.WriteLine($"\nFinal String Length: {largeSentence.Length}");



            //PART 3
            StringBuilder sb = new StringBuilder(); //resizable array of characters.

            for (int i = 0; i < 1000; i++)
            {
                sb.Append("hello ");  // existing buffer. doesnt create new object each time. and resizes as needed. hash stays the same. no new hashes made that doesnt get collected.
            }

            // Convert to immutable string only once
            string largeSentenceSB = sb.ToString();

            Console.WriteLine($"Final String Length: {largeSentenceSB.Length}");


            //PART 4
            
            StringBuilder sbone = new StringBuilder(); sbone.Append("one");
            Console.WriteLine($"Hashcode for sbone: {sbone.GetHashCode()}");
            StringBuilder sbTwo = sbone; //reference assignment
            Console.WriteLine($"Hashcode for sbTwo: {sbTwo.GetHashCode()}");
            sbTwo.Append("s"); //changes sbone as well since both reference same object.

            Console.WriteLine(sbone ==sbTwo); //true, both reference same object


        }
    }
}
