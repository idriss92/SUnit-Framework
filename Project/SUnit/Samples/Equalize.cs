using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUnit.Framework;
//using System.

namespace SUnit.Samples
{
    class Equalize
    {
        static void Main(string[] args)
        {
            int valeur = 0;
            int resultat = Factorielle(valeur);
            if (resultat != 1)
                Console.WriteLine("Le test a raté");

            valeur = 1;
            resultat = Factorielle(valeur);
            if (resultat != 1)
                Console.WriteLine("Le test a raté");

            valeur = 2;
            resultat = Factorielle(valeur);
            if (resultat != 2)
                Console.WriteLine("Le test a raté");

            valeur = 3;
            resultat = Factorielle(valeur);
            if (resultat != 6)
                Console.WriteLine("Le test a raté");

            valeur = 4;
            resultat = Factorielle(valeur);
            if (resultat != 24)
                Console.WriteLine("Le test a raté");
        }

        public static int Factorielle(int a)
        {
            int total = 1;
            for (int i = 1; i <= a; i++)
            {
                total *= i;
            }
            return total;
        }

        public static  float Divise(int a , int b)
        {
            return a / b;

        }

        public static double RacineCarre(int a)
        { 
            return Math.Sqrt(a);
        }
    }

    [TestClass]
    public class MathTests
    {
        [Test]
        public void Factorielle_AvecValeur3_Retourne6()
        {
            int valeur = 3;
            int resultat = Equalize.Factorielle(valeur);
            Assert.Equal(resultat,6);
        }

        [Test]
        public void Factorielle_AvecValeur10_Retourne1()
        {
            int valeur = 10;
            int resultat = Equalize.Factorielle(valeur);
            Assert.Equal(resultat,1);
        }
    }

    [TestClass]
    public class SecondTests
    {
        [Test]
        public void RacineCarre_AvecValeur9_Retourne3()
        {
            int valeur = 9;
            double resultat = Equalize.RacineCarre(9);
            Assert.Equal(resultat,valeur);
        }

        [Test]
        public void RacineCarre_AvecValeur81_Retourne9()
        {
            int valeur = 9;
            var resultat = Equalize.RacineCarre(81);
            Assert.Equal(resultat,valeur);
        }
    }

    [TestClass]
    public class Divise
    {
        [Test]
        public void Divisepar2()
        {
            var result = Equalize.Divise(5, 2);
            Assert.Equal(result, 2.5);
        }


        [Test]
        public void Divise3par3()
        {
            var result = Equalize.Divise(3, 3);
            Assert.Equal(result,1);
        }

        [Test]
        public void Divisionpar10()
        {
            var result = Equalize.Divise(5, 10);
            Assert.NotEqual(result, 21);
        }

        [Test]
        public void Division_par_100()
        {
            var result = Equalize.Divise(100, 100);
            Assert.NotEqual(result, 1);
        }

    }
}
