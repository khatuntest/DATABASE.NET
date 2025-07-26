using Level2_S4.Classes;
using System;
using System.Buffers.Text;
using System.Collections;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;
using static Level2_S4.Classes.User;
using static System.Reflection.Metadata.BlobBuilder;

namespace Level2_S4{
    internal class Program{
        static void Main(string[] args)
        {

        #region Question 1: Custom Exception – UserNotFoundException
        /*Requirements:
            Create a class called User with properties Id and Username.
            Create a List<User> containing 3 users.
            Create a custom exception class called UserNotFoundException.
            Implement a method GetUsernameById(int id, List<User> users) that:
                          1) Returns the username if found.
                          2) Throws a UserNotFoundException if the ID is not found.
            Test the method in Main() using:
                                 1) An ID that exists.
                                 2) An ID that doesn't exist.
        */

        //List<User> users = new List<User>()
        //{
        //    new User{ID = 1 , Name = "Menna"},
        //    new User{ID = 2 , Name = "Muhammed"},
        //    new User{ID = 3 , Name = "Khaled"},

        //};
        //try
        //{
        //    Console.WriteLine(User.GetUsernameById(2,users));
        //    Console.WriteLine(User.GetUsernameById(4, users));
        //}
        //catch (UserNotFoundException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        #endregion

        #region Question 2: Override Equals and GetHashCode
        /* Requirements:
             Create a class Book with properties Title and Author.
             Override the Equals and GetHashCode methods to compare based on content, not reference.
             Create two Book objects with the same values.
             Compare them using:   .Equals()   and  .GetHashCode()
             Add both books to a HashSet<Book> and print the result.
        */

        //Book book1 = new Book() {Title = "T1" , Author="A1" };
        //Book book2 = new Book() { Title = "T1", Author = "A1" };

        //Console.WriteLine(book1.Equals(book2));
        //Console.WriteLine(book1.GetHashCode());
        //Console.WriteLine(book2.GetHashCode());

        //var hash = new HashSet<Book>();
        //hash.Add(book1);
        //hash.Add(book2);
        //Console.WriteLine(hash.Count);
        //foreach (var item in hash) 
        //    Console.WriteLine(item);


        #endregion

        #region Question 3: IEnumerable and Yield
        /* Requirements:
            Create a method GetOddNumbers(int max) that returns IEnumerable<int>.
            Use yield return inside the method to return all odd numbers up to max.
            In Main(), call this method with max = 15 and print the results.
             Briefly explain(in comments or a note) the difference between:
                                             1) Returning a full list
                                             2) Using yield return.
        */

          //foreach(var i in GetOddNumbers(15))
          //  {
          //      Console.WriteLine(i);
          //  }


            /*
             * The Different between :
             * 1) Returning a full list => create all values then returns all list at once
              2) Using yield return.=> return one item at a time and print it then return next item 
             */

            #endregion



        }
        public static  IEnumerable<int> GetOddNumbers(int max)
        {
            for (int i = 0; i <= max; i++)
            { 
                if(i % 2 == 1)
                {
                    yield return i;
                }
            }
        }


    }

}
