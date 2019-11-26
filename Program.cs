using System;
using System.Collections.Generic;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMovies = new List<DVD>
            {
                new DVD { Title = "Out in the Dark", Genre = "Drama|Romance"},
                new DVD { Title = "Zapped!", Genre = "Comedy|Sci-Fi"},
                new DVD { Title = "Neighbours", Genre = "Comedy"},
                new DVD { Title = "Thing, The", Genre = "Action|Horror|Sci-Fi|Thriller"},
                new DVD { Title = "Around the Block", Genre = "Drama"},
                new DVD { Title = "Corto Maltese: Under the Sign of Capricorn (Sous le signe du capricorne)", Genre = "Animation|Drama|Romance|War"},
                new DVD { Title = "Warlock: The Armageddon", Genre = "Horror"},
                new DVD { Title = "Nico and Dani", Genre = "Comedy|Drama|Romance"},
                new DVD { Title = "What Doesn't Kill You", Genre = "Crime|Drama"},
                new DVD { Title = "Reap the Wild Wind", Genre = "Action|Adventure|Drama"},
                new DVD { Title = "Last Days Here", Genre = "Documentary"},
                new DVD { Title = "Parental Guidance", Genre = "Comedy"},
                new DVD { Title = "Saving Shiloh", Genre = "Children|Drama"},
                new DVD { Title = "Moonshot", Genre = "Drama"},
                new DVD { Title = "Kadosh", Genre = "Drama"},
                new DVD { Title = "Stanley Kubrick: A Life in Pictures", Genre = "Documentary"},
                new DVD { Title = "Clown and the Kid, The", Genre = "Drama"},
                new DVD { Title = "Confetti", Genre = "Comedy"},
                new DVD { Title = "Setup (Set Up)", Genre = "Action|Crime|Drama"},
                new DVD { Title = "Captain Video: Master of the Stratosphere", Genre = "Adventure|Sci-Fi"},
                new DVD { Title = "Underworld: Evolution", Genre = "Action|Fantasy|Horror"},
                new DVD { Title = "Nothing Left to Fear", Genre = "Horror"},
                new DVD { Title = "Shanghai Gesture, The", Genre = "Drama|Film-Noir"},
                new DVD { Title = "In My Father's Den", Genre = "Drama"},
                new DVD { Title = "Scapegoat, The", Genre = "Drama"},
                new DVD { Title = "None But the Lonely Heart", Genre = "Drama|Romance"},
                new DVD { Title = "Cameron's Closet", Genre = "Horror"},
                new DVD { Title = "Inferno", Genre = "Drama"},
                new DVD { Title = "Splatter University", Genre = "Horror"},
                new DVD { Title = "Flash Point", Genre = "Action"}

           };

            var allBooks = new List<Book>
            {
                new Book { Author = "Chinua Achebe", Title = "Things Fall Apart" },
                new Book { Author = "Hans Christian Andersen", Title = "Fairy tales" },
                new Book { Author = "Dante Alighieri", Title = "The Divine Comedy" },
                new Book { Author = "Unknown", Title = "The Epic Of Gilgamesh" },
                new Book { Author = "Unknown", Title = "The Book Of Job" },
                new Book { Author = "Unknown", Title = "One Thousand and One Nights" },
                new Book { Author = "Geoffrey Chaucer", Title = "The Canterbury Tales" },
                new Book { Author = "Jane Austen", Title = "Pride and Prejudice" },
                new Book { Author = "Miguel de Cervantes", Title = "Don Quijote De La Mancha" },
                new Book { Author = "Samuel Beckett", Title = "Molloy, Malone Dies, The Unnamable, the trilogy" },
                new Book { Author = "Giovanni Boccaccio", Title = "The Decameron" },
                new Book { Author = "Jorge Luis Borges", Title = "Ficciones" },
                new Book { Author = "Emily Bronte", Title = "Wuthering Heights" },
                new Book { Author = "Albert Camus", Title = "The Stranger" },
                new Book { Author = "Knut Hamsun", Title = "Hunger" },
                new Book { Author = "Ernest Hemingway", Title = "The Old Man and the Sea" },
                new Book { Author = "Homer", Title = "Iliad" },
                new Book { Author = "Homer", Title = "Odyssey" },
                new Book { Author = "Henrik Ibsen", Title = "A Doll's House" },
                new Book { Author = "James Joyce", Title = "Ulysses" },
                new Book { Author = "Franz Kafka", Title = "Stories" },
            };
        
            Console.WriteLine("Which listings would you like to see?");
            Console.WriteLine("1. Movies");
            Console.WriteLine("2. Books");

            var selection = Console.ReadLine();

            if (selection == "1")
            {
                allMovies.ForEach(m => Console.WriteLine($"{m.Title} ({m.Genre})"));
            }

            if (selection == "2")
            {
                allBooks.ForEach(b => Console.WriteLine($"{b.Title} by {b.Author}"));
            }
        }
    }
}
