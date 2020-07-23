using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab_4._2_Movies
{
    class Movie 
    {
        private string _title;
        private string _category;

        public string Title 
        {
            get
            {
                return _title;
            }

        }

        public string Category
        {
            get
            {
                return _category;
            }
            
        }
        public Movie(string thecategory, string thetitle)
        {
            _category = thecategory;
            _title = thetitle;
        }

    };

    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>(); //list of movie titles and their catagory
            movies.Add(new Movie("action", "007 No Time To Die"));
            movies.Add(new Movie("action", "Avengers Endgame"));
            movies.Add(new Movie("action", "Mad Max Fury Road"));
            movies.Add(new Movie("drama", "Joker"));
            movies.Add(new Movie("drama", "The Irishman"));
            movies.Add(new Movie("drama", "A Scanner Darkly"));
            movies.Add(new Movie("horror", "Aliens"));
            movies.Add(new Movie("horror", "House of 1000 Corpses"));
            movies.Add(new Movie("horror", "Evil Dead"));
            movies.Add(new Movie("scifi", "Rogue One: A Star Wars Story"));
            movies.Add(new Movie("scifi", "Guardians of the Galaxy"));
            movies.Add(new Movie("scifi", "Chappie"));
            movies.Add(new Movie("comedy", "Grandma's Boy"));
            movies.Add(new Movie("comedy", "Army of Darkness"));
            movies.Add(new Movie("comedy", "The Big Lebowski"));

            Console.WriteLine("+========================================+");
            Console.WriteLine($"| Welcome to the Movie List Application! |"); //Title of program
            Console.WriteLine("+========================================+\n");
            Console.WriteLine($"There are 3 movies to choose from in each catagory.\n"); //Informs user contents of program

            bool running = true;
            while (running) //loops the program if the user would like to view more info
            {
                Console.WriteLine($"Your category options are: Action, Drama, Horror, SciFi, and Comedy\n");
                Console.Write($"Which category are you interested in?: "); //asks for user input
                
                string entry = Console.ReadLine().ToLower();
                if (!(entry == "action" || entry == "drama" || entry == "horror" || entry == "scifi" || entry == "comedy")) //checks if input is not equal to the specific catagories
                {
                    Console.WriteLine($"That input is not valid, please try again.");
                }
                foreach (Movie title in movies)
                {
                    if (title.Category == entry)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" - "+title.Title);
                    }
                }
                Console.WriteLine();                
                Console.Write($"Continue? (y/n): ");

                string cont = Console.ReadLine().ToLower();
                if (cont == "y" || cont == "yes")
                {
                    running = true;
                    {
                        Console.Clear();
                    }
                }
                else if (cont == "n" || cont == "no")
                {
                    running = false;
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Goodbye!");
                    }

                }

            }
                  
            /*
            action - 007 No Time To Die - Avengers Endgame - Mad Max Fury Road
            drama - Joker - The Irishman - A Scanner Darkly
            horror - Aliens - House of 1000 Corpses - Evil Dead
            scifi - Rogue One: A Star Wars Story - Guardians of the Galaxy - Chappie
            comedy - Grandma's Boy - Army of Darkness - The Big Lebowski
            */

        }
    }
}
