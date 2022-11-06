using System;
using System.Text.RegularExpressions;

namespace bank2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] user = new object[0];
            Console.WriteLine("\t\t\t\t\t\tRegister ekrani");
            
        tryagain:
            Console.WriteLine("Username daxil edin;");
            string username = Console.ReadLine();
            Regex regex2 = new Regex(@"^[A-Z]?[a-z]{1,14}?\S[1-9]{1,14}$");
            Match regex2Match = regex2.Match(username);

            Console.WriteLine("Ad daxil edin;");
            string Name = Console.ReadLine();
            Console.WriteLine("Soyad daxil edin;");
            string Surname = Console.ReadLine();
            Regex regex = new Regex(@"^[A-Z][a-z]{1,14}$");
            Match regexMatch = regex.Match(Name);
          
            Match regex4Match = regex.Match(Surname);


            Console.WriteLine("E-poct daxil edin;");
            string mail = Console.ReadLine();
            Regex regex3 = new Regex(@"^[a-z0-9](\.?[a-z0-9]){5,}@g(oogle)?mail\.com$");
           Match regex3Match = regex3.Match(mail);


            Console.WriteLine("Yasinizi daxil edin;");
            string age = Console.ReadLine(); 
            Regex regex5 = new Regex(@"^[1 - 9]{1,3}$");
            Match regex5Match = regex5.Match(age);

            Console.WriteLine("Sifre daxil edin;");
            string password = Console.ReadLine();
            Regex regex6 = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|\]).{8,32}$");
            Match regex6Match = regex6.Match(password);

            Console.WriteLine("Nomrenizi daxil edin;");
            string number = Console.ReadLine();
            Regex regex7 = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}");
            Match regex7Match = regex7.Match(password);

            if (regexMatch.Success && regex2Match.Success && regex3Match.Success && regex4Match.Success && regex5Match.Success && regex6Match.Success && regex7Match.Success)
            {
                Console.WriteLine("You are registred");
                var User = new
                {
                    username=username,
                    name = Name,
                    surname = Surname,
                    mail = mail,
                    age = age,
                    password = password,
                    number= number
                };
                Array.Resize(ref user , user.Length+1 );
                user[user.Length - 1] = User;
                Console.WriteLine("user created");

            }
            else
            {
                Console.WriteLine("You have a mistake, you need to look again");

                Console.Clear();
                Console.WriteLine("You have a mistake, you need to look again");
                goto tryagain;
            }
           
           
            
           //array[array.Length - 1]= user;
           // Console.WriteLine(array[0]);





        }
    }
}
