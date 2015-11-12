using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB15
{
    enum PasswordStrenght
    {
        easy, normal, hard
    }
    // Funkcija za generiranje sluchajna lozinka
    // PasswordStrenght e tip enumeracija (easy, normal , hard)
    //static string generatePassword ( PasswordStrenght passwordStrenght ) {
    // easy lozinkata treba da ima do 6 znaci (samo mali bukvi)
    // normal lozinkata treba da ima od 6 do 10 znaci (da sodrzhi golemi bukvi i
    // brojki
    // hard loznikata treba da ima povekje od 10 znaci i da sodrzhi mali, golemi
    // bukvi i specijalni znaci
    class Program
    {
        static Random random = new Random();
        
        static string generatePassword(PasswordStrenght passwordStrenght)
        {

            StringBuilder lozinka = new StringBuilder();
            int temp = 0;

            if (passwordStrenght.ToString() == "easy")
            {
                String chars = "abcdefghijklmnopqrstuvwxyz";
                for (int i = 0; i < 6; i++)
                {
                    lozinka.Append(chars[random.Next(0, chars.Length - 1)]);
                }
            }
            if (passwordStrenght.ToString() == "normal")
            {
                String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                temp = random.Next(6, 12);
                for (int i = 0; i < temp; i++)
                {
                    if (i < temp - 3)
                    {
                        lozinka.Append(chars[random.Next(0, chars.Length - 1)]);
                    }
                    else
                    {
                        lozinka.Append(chars[random.Next(0, chars.Length - 1)]);
                    }

                }

            }
            if (passwordStrenght.ToString() == "hard")
            {

                temp = random.Next(10, 30);
                for (int i = 0; i < temp; i++)
                {
                    lozinka.Append((char)random.Next(34, 126));
                }
            }

            return lozinka.ToString();
        }

        static void Main(string[] args)
        {

            //PasswordStrenght passwordStrenght = PasswordStrenght.easy;
            //Console.WriteLine(passwordStrenght.ToString());



            String[] EasyPassword = new String[3];
            String[] NormalPassword = new String[3];
            String[] HardPassword = new String[3];
            PasswordStrenght[] easy = new PasswordStrenght[3];
            PasswordStrenght[] hard = new PasswordStrenght[3];
            PasswordStrenght[] normal = new PasswordStrenght[3];
            for (int i = 0; i < 3; i++)
            {
                easy[i] = PasswordStrenght.easy;
            }

            for (int i = 0; i < 3; i++)
            {
                EasyPassword[i] = generatePassword(PasswordStrenght.easy);
                NormalPassword[i] = generatePassword(PasswordStrenght.normal);
                HardPassword[i] = generatePassword(PasswordStrenght.hard);
            }

            Console.WriteLine("Vnesi  lozinki oddeleni so prazno mesto");
            string passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < parts.Length; j++)
                {
                    Console.WriteLine();
                    Console.WriteLine("easy = {0} \n Vnesena = {1}", EasyPassword[i], parts[j]);
                    Console.WriteLine();
                    Console.WriteLine("normal = {0} \n Vnesena = {1} ", NormalPassword[i], parts[j]);
                    Console.WriteLine();
                    Console.WriteLine("hard = {0} \n Vnesena = {1} ", HardPassword[i], parts[j]);
                    Console.WriteLine();
                }
               
            }


            Console.ReadKey();
        }
    }
}
