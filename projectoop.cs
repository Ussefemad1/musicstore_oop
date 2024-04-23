using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp9
{
    class Admin
    {

        public string Username { get; set; }
        protected string Password { get; set; }
        public Admin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
    class Music 
    {
        public Music() { }
        public string category;
       public string musicname;
        public string artist;
        List<string> category1 = new List<string>();
        List<string> musicname1 = new List<string>();
        List<string> artist1 = new List<string>();
        public virtual void  Add1()
        {
            Console.WriteLine("Please Enter the music category, name and artist");
            Console.WriteLine("Category :\n ");
            category = Console.ReadLine();
            Console.WriteLine("name : \n ");
            musicname = Console.ReadLine();
            Console.WriteLine("Artist :");
            artist = Console.ReadLine();
            category1.Add(category);
            musicname1.Add(musicname);
            artist1.Add(artist);
            Console.WriteLine("music Added Successfully");

      
            


        }
        public virtual void show()
        {
            if (category1.Count > 0 && musicname1.Count > 0 && artist1.Count > 0)
            {
                foreach (string a in category1)
                {
                    Console.WriteLine(a);
                }
                foreach (string a in musicname1)
                { Console.WriteLine(a); }
                foreach (string a in artist1)
                { Console.WriteLine(a); }
            }
            else
            {
                Console.WriteLine("No data to show");
            }
        }
        public virtual void delete()
        {
            if (category1.Count > 0 && musicname1.Count > 0 && artist1.Count > 0)

            {

                Console.WriteLine("Please Enter the music name you want to delete");
                Console.WriteLine("name : \n ");
                musicname = Console.ReadLine();
                category1.Remove(category);
                musicname1.Remove(musicname);
                artist1.Remove(artist);
                Console.WriteLine("music deleted Successfully");
            }
            else
            {
                Console.WriteLine("No data to delete");
            }

        }





    }
    class instruments : Music
    {
        public string instname;
        public int instprice;
        List<string> instname1 = new List<string>();
        List<int> instprice1 = new List<int>();
     

        public instruments() { }
        public void count()
        {
            if (instname1.Count > 0)
            {


                int count1 = 0;
                for (int i = 0; i < instname1.Count; i++)
                {
                    count1++;

                }
                count1.ToString();
                Console.WriteLine(count1);
            }
            else
            {
                Console.WriteLine("no data to count");
            }
        }
        public override  void Add1()
        {
            Console.WriteLine("Please Enter the instrument name and price");
            Console.WriteLine("name : \n ");
            instname = Console.ReadLine();
            instname1.Add(instname);
            Console.WriteLine("price : ");
            instprice = int.Parse(Console.ReadLine());
            instprice1.Add(instprice);
            Console.WriteLine("instrument successfully added");
               
          
     

        }
        public void instquantity(string instname)
        {
            int count1 = 0;
            if (instname1.Count > 0)
            {
                for (int i = 0; i < instname1.Count; i++)
                {
                    if (instname1[i] == instname)
                    {
                        count1++;
                    }
                    count1.ToString();
                    Console.WriteLine(count1);

                }
            }
            else
            {
                Console.WriteLine("No available quantity");
            }

        }
        public override void delete()
        {
            if (instname1.Count > 0 && instprice1.Count > 0)

            {

                Console.WriteLine("Please Enter the instrument name you want to delete");
                Console.WriteLine("name : \n ");
                instname = Console.ReadLine();
                instname1.Remove(instname);
                instprice1.Remove(instprice);
                Console.WriteLine("instrument deleted Successfully");
            }
            else
            {
                Console.WriteLine("No data to delete");
            }

        }
        public override void show()
        {
            if (instname1.Count > 0 && instprice1.Count > 0)
            {
                foreach (string a in instname1)
                {
                    Console.WriteLine(a);
                }
                foreach (int a in instprice1)
                {
                    a.ToString();
                    Console.WriteLine(a); 
                }
               
            }
            else
            {
                Console.WriteLine("No data to show");
            }
        }













    }













    internal class Program
    {
        static void Main(string[] args)
        {
            Music m1 = new Music();
            instruments i1 = new instruments();
          
            
            
            
           
            
            
        }
    }
}
