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
        public virtual void add2(string musicname, string artist, string category)
        {
            category1.Add(category);
            musicname1.Add(musicname);
            artist1.Add(artist);
        }
        public virtual void show()
        {
            if (category1.Count > 0 && musicname1.Count > 0 && artist1.Count > 0)
            {
                for(int i = 0; i<musicname1.Count && i<artist1.Count && i<category1.Count; i++)
                {
                    Console.WriteLine($" song name : {musicname1[i]} , artist : {artist1[i]} , category : {category1[i]}");
                }
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
                   
                }
                else
                {
                    Console.WriteLine("Song is not found");
                }

            }

        }

    }
    class instruments : Music
    {
        public string instname;
        public int instprice;
        public int count1 = 0;
        public int count3 = 0;
        public int count4 = 0;
        public int newprice;
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
            Console.WriteLine("Please Enter the instrument name, price and quantity");
            Console.WriteLine("name : \n ");
            instname = Console.ReadLine();
            instname1.Add(instname);
            Console.WriteLine("price : ");
            instprice = int.Parse(Console.ReadLine());
            instprice1.Add(instprice);
            Console.WriteLine("quantity :");
            count3 = int.Parse(Console.ReadLine());
            quantity.Add(count3);
            Console.WriteLine("instrument successfully added");
        }
        public void add2(string instname, int instprice , int quantity2)
        {
            instname1.Add(instname);
            instprice1.Add(instprice);
            quantity.Add(quantity2);

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
               for(int i = 0; i< instname1.Count && i<instprice1.Count && i<quantity.Count; i++)
                {
                    Console.WriteLine($"Instrument name : {instname1[i]} ,  price : {instprice1[i]} , quantity {quantity[i]}");
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
            show();
            instname = Console.ReadLine();
            if (instname1.Contains(instname))
            {
                Console.WriteLine("Item price : ");
                instprice = int.Parse(Console.ReadLine());
                Console.WriteLine("what quantity do you want to order from the choosen item?\n");
                count3 = int.Parse(Console.ReadLine());
                newprice = instprice * count3;
                instCart.Add(instname);
                Cartprice.Add(newprice);
            }
            else
            {
                Console.WriteLine("Item unavailable");
            }         
        }
        public void removecart()
        {
            if (instCart.Count > 0)
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
            else
            {
                Console.WriteLine("Cart is empty");
            }
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
                else
                {
                    Console.WriteLine("instrument not found");
                }
            }

        }
        public void showcart()
        {
            if (instCart.Count > 0)
            {
                foreach (string a in instCart)
                {
                    Console.WriteLine($" intsrument name : {a}\n");
                }
                foreach (int b in Cartprice)
                {
                    Console.WriteLine($" instrument price : {b}");
                }
            }
            else
            {
                Console.WriteLine("Cart is empty");
            }
        }
        public void order()
        {
            if (instCart.Count > 0)
            {
                Console.WriteLine("These are the items added to cart");
                showcart();
                int choose;
                int shipping = 50;
                Console.WriteLine("Do you want to order it?\n 1- yes\n 2- No");
                Console.WriteLine("your choice : ");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    int sum = 0;
                    for (int i = 0; i < Cartprice.Count; i++)
                    {
                        sum = sum + Cartprice[i];
                    }
                    Console.WriteLine($"your total will be {sum} + shipping {shipping} so it is {sum + shipping}");

                    Console.WriteLine("you sure u want to submit the order?");
                    string choice2;
                    choice2 = Console.ReadLine();
                    if (choice2 == "yes" || choice2 == "Yes")
                    {
                        foreach (string item in instCart)
                        {
                            solditems.Add(instname);
                            int index=instname1.IndexOf(item);
                            quantity[index] =quantity[index] - count3;

                        }

                    }
                    Console.WriteLine("Thank you for ordering");
                }
                else if (choose == 2)
                {
                    Console.WriteLine("Okay Thank you for visiting our store");
                }
            }
            else
            {
                Console.WriteLine("Cart is empty");
            }
        }

        public void showsold()
        {
            foreach (string a in solditems)
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
        m1.add2("shape of you", "Ed sheeran", "pop");
        m1.add2("Rolling in the deep", "Adele", "pop");
        m1.add2("Bnkhaf", "Cairokee", "Rock");
        m1.add2("Benna maad", "Amr diab", "Rock");
        i1.add2("Electric guitar", 250 ,5);
        i1.add2("piano", 500 ,6);
        i1.add2("saxophone", 600 ,3);
        i1.add2("Flute", 150 ,9);



        String choose;
        string choose2;
        int choose3;
        Console.WriteLine("Are you Admin or Customer?");
        choose = Console.ReadLine();
        if (choose == "Admin" || choose == "admin")
        {
            while (true)
            {
                Console.WriteLine("Are you a new admin or existing one");
                choose2 = Console.ReadLine();
                if (choose2 == "new admin")
                {
                    a1.admin_register();
                }
                else if (choose2 == "existing one")
                {
                    a1.signin();
                    while (true)
                    {
                        Console.WriteLine("Please choose an option from the menu\n 1-Add item\n 2-Show items\n 3-Delete items\n 4-show sold items\n 5- Add song\n 6- Delete song\n 7- show songs\n 8- search a song\n 9- How many items available\n 10- sign out");
                        choose3 = int.Parse(Console.ReadLine());
                        switch (choose3)
                        {
                            case 1:
                                i1.Add1();
                                break;
                            case 2:
                                i1.show();
                                break;
                            case 3:
                                i1.delete();
                                break;
                            case 4:
                                i1.showsold();
                                break;
                            
                            case 5:
                                m1.Add1();
                                break;
                            case 6:
                                m1.delete();
                                break;
                            case 7:
                                m1.show();
                                break;
                            case 8:
                                m1.search();
                                break;
                            case 9:
                                i1.count(); break;
                            case 10:
                                a1.signout(); break;



                        }


                    }
                }



            }
        }
        else if (choose == "customer" || choose == "Customer")
        {


            while (true)
            {
                Console.WriteLine("Here are the items and songs available");
                m1.show();
                i1.show();

                Console.WriteLine("Please choose an option from the menu below\n 1- add item to cart\n 2- delete item from cart\n 3-search an item\n 4- order item\n 5- search a song\n ");
                int choose4;
                choose4 = int.Parse(Console.ReadLine());
                switch (choose4)
                {
                    case 1:
                        i1.addtocart(); break;
                    case 2:
                        i1.removecart(); break;
                    case 3:
                        i1.search(); break;
                    case 4:
                        i1.order(); break;
                    case 5:
                        m1.search(); break;



                }


            }

        }
    }



}
