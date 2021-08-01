using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Man jahangir = new Man();
            jahangir.eat("rice");

            jahangir.eat("rice","egg");
        }


    }


class Man{
    public void eat(String foodOne){
   Console.WriteLine($"I am eating {foodOne}");
    }
    public void eat(String foodOne){
   Console.WriteLine($"Eating {foodOne}");
    }

    public void eat(String foodOne,String foodTwo){
   Console.WriteLine($"I am eating {foodOne} and {foodTwo}");
    }
}

}
