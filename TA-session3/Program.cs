using System;
using System.Collections.Generic;
using System.Linq;

namespace TASession3
{

    public class User
    {
        private int _userID;
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length != 0)
                {
                    _username = value;
                };
            }
        }

        public User(int userID)
        {
            this.UserID = userID;
        }

        public User()
        {

        }

        public User(int userID, string username)
        {
            this.UserID = userID;
            this.Username = username;
        }


        



    }

    public class Dogs
        {
            public string Name { get; set; }
            public int Number { get; set; }
            public bool IsHappy { get; set; }
        }

    internal class Program
    {
        static void Main(string[] args)
        {

            User userObject = new User() { UserID = 124125, Username = "testUsername" };

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 1, 15, 14 };

            List<int> distinctNumbers = numbers.Distinct().ToList();

            // int sum = distinctNumbers.Aggregate((x, y) => {
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // return x + y;
            // });

            // Console.WriteLine($"The sum is {sum}");

            // var result = distinctNumbers.Chunk(4).ElementAt(2).ToList();


            // result.ForEach(result1 => Console.WriteLine(result1));


            List<Dogs> dogsList = new List<Dogs>{
                new Dogs{ Name="bunny" ,Number=1 , IsHappy=true },
                new Dogs{ Name="misha" ,Number=10 , IsHappy=true },
                new Dogs{ Name="pisha" ,Number=13 , IsHappy=false },
                new Dogs{ Name="max" ,Number=18 , IsHappy=true },
                new Dogs{ Name="rocky" ,Number=91 , IsHappy=true },
                new Dogs{ Name="kachal" ,Number=31 , IsHappy=false },
                new Dogs{ Name="padari" ,Number=28 , IsHappy=true },
                new Dogs{ Name="whiny" ,Number=26 , IsHappy=true }
            };


            IEnumerable<Dogs> happyDogs = from dogs in dogsList
                                          where dogs.IsHappy == true
                                          select dogs;

            


            List<Dogs> newDogsList = happyDogs.ToList();
            newDogsList.Add(new Dogs { Name = "jacky", Number = 43, IsHappy = true });

            newDogsList.ForEach(dog => Console.WriteLine(dog.Name));
            


        }
    }
}