using ConsoleApp9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp9
{
    class Admin
    {

        public string username { get; set; }
        protected string password { get; set; }
        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        List<string> username1 = new List<string>();

        List<string> password1 = new List<string>();
        public Admin() { }

     
        public void admin_register()
        {
            Console.WriteLine("Please enter your username : ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password :");
            password = Console.ReadLine();

            if (username1.Contains(username))
            {
                Console.WriteLine("this username already exists please choose another username");
                return;
            }
            username1.Add(username);
            password1.Add(password);
            Console.WriteLine("registered succesfully");
        }
        public void admin_delete()
        {
            Console.WriteLine("Please enter your username : ");
            username = Console.ReadLine();
            if (username1.Contains(username))
            {
                int i = username1.IndexOf(username);
                password1.RemoveAt(i);
                username1.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("username is not available");
                return;
            }

        }
        public void signout()
        {
            Console.Clear();
            Console.WriteLine("signed out succesfully");
        }
        public void signin()
        {
            Console.WriteLine("Please enter your username : ");
                username = Console.ReadLine();
            Console.WriteLine("Please enter your password :");
            password = Console.ReadLine();

            if (!username1.Contains(username))
            {
                Console.WriteLine("username not available \n register first");
                return;
            }
            int i = username1.IndexOf(username);
            if (password1[i] == password)
            {
                Console.WriteLine("signed in succesfully");
                return;
            }
            else
                Console.WriteLine("wrong password please try again");



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
        List<string> musicorder = new List<string>();
      
        public virtual void Add1()
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
        public virtual void search()
        {

            Console.WriteLine("please enter the musicname :");
            musicname = Console.ReadLine();
            foreach (string a in musicname1)
            {
                if (a == musicname)
                {
                    Console.WriteLine("Song is found");
                    Console.WriteLine(musicname);
                    Console.WriteLine(category);
                    Console.WriteLine(artist);
                }
              
            
            }
            
        }
     






    }








    class instruments : Music
    {
        public string instname;
        public int instprice;
       public  int count1 = 0;
        List<string> instname1 = new List<string>();
        List<int> instprice1 = new List<int>();
        List<string> instorder = new List<string>();
        List<string> instCart = new List<string>();
        List<int> Cartprice = new List<int>();
        List<string> solditems = new List<string>();
        List<int> quantity = new List<int>();   



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
        public override void Add1()
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
            
            if (instname1.Count > 0)
            {
                for (int i = 0; i < instname1.Count; i++)
                {
                    if (instname1[i] == instname)
                    {
                        count1++;
                    }
                    count1.ToString();


                }
                quantity.Add(count1);
                Console.WriteLine(count1);
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
        public void addtocart()
        {

            Console.WriteLine("Please choose an item to add to cart");
            instname = Console.ReadLine();
            instCart.Add(instname);
            Console.WriteLine("Item price : ");
            instprice = int.Parse(Console.ReadLine());
            Cartprice.Add(instprice);
            Console.WriteLine("Item successfully added");

        }
        public void removecart()
        {
            Console.WriteLine("Please choose an item to remove from cart");
            foreach (string a in instCart)
            {
                Console.WriteLine(a);
            }
            instname = Console.ReadLine();
            instCart.Remove(instname);
            Console.WriteLine("Item successfully removed");
        }
        public override void search()
        {

            Console.WriteLine("please enter the instrument name :");
            instname = Console.ReadLine();
            foreach (string a in instname1)
            {
                if (a == instname)
                {
                    Console.WriteLine("instrument is found");
                    Console.WriteLine(instname);
                    Console.WriteLine(instprice);
                  
                }


            }

        }
        public void showcart()
        {
            foreach (string a in instCart)
            {
                Console.WriteLine($" intsrument name : {a}\n");
            }
            foreach(int b in Cartprice)
            {
                Console.WriteLine($" instrument price : {b}");
            }




        }
        public void order()
        {
            Console.WriteLine("These are the items added to cart");
            showcart();
            int choose;
            int shipping = 50;
            int count2;
            Console.WriteLine("Do you want to order it?\n 1- yes\n 2- No");
            Console.WriteLine("your choice : ");
            choose = int.Parse(Console.ReadLine());
            if (choose == 1) 
            {
                int sum = 0;
                for (int i = 0; i<Cartprice.Count; i++)
                {
                    sum = sum + Cartprice[i];
                }
                Console.WriteLine($"your total will be {sum} + shipping {shipping} so it is {sum + shipping}\n");
                Console.WriteLine("you sure u want to submit the order?");
                string choice2;
                choice2 = Console.ReadLine();
                if(choice2 == "yes" || choice2 =="Yes")
                {
                    solditems.Add(instname);
                    quantity.Remove(count1);
                    count2 = count1 - instCart.Count;
                    quantity.Add(count2);
                }
                Console.WriteLine("Thank you for ordering");
            }
            else if (choose ==2)
            {
                Console.WriteLine("Okay Thank you for visiting our store");
            }
            
            

        }
        public void showsold()
        {
            foreach(string a in solditems)
            {
                Console.WriteLine($" sold items :\n {a}");
            }
        }
        














    }
}













    internal class Program
    {
        static void Main(string[] args)
        {
           Music m1 = new Music();  
            instruments i1 = new instruments();
        Admin a1 = new Admin();
       
       
       
       
        
       
         
        
        







        }
    }

