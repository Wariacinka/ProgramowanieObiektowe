using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class Ułamek //Utwórz klasę Ułamek prywatne zmienne licznik i mianownik 
    {
        private int licznik;
        private int mianownik;


        public Ułamek() //konstruktor domyślny
        {

        }

        public Ułamek(int licznik, int mianownik) //konstruktor z dwoma argumentami,

        {


        }

        public Ułamek (Ułamek licznik , Ułamek mianownik) //konstruktor kopiujący (1 argument).

        {


        }

        public override string ToString() //Dodaj metodę ToString().

        {
            return licznik + "+" + mianownik; //Przeładuj operatory + - * /.


        }
        //Zaimplementuj interfejsy IEquatable i IComparable
        public interface icomparable
        {
            int compareTo(object obj);

        }
        public interface icompare<t>
        {
            int compareto(t other);

        }
        public int compareto(object obj)
        {
            return compareto((Ułamek)obj);

        }
        public int compareto(Ułamek other)
        {
            double d1 = (double)licznik / mianownik;
            double d2 = (double)other.licznik / mianownik;
            if (d1 == d2)
                return 0;
            return d1 < d2 ? -1 : 1; 
        }


        


    }

   
   

}