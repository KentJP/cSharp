using System;
using System.Collections.Generic;

namespace VideoMenu
{
    class Program

    {

        static List<Video> videos = new List<Video>();
        static int Id = 0;

        static void Main(string[] args)
        {
            
            var video1 = new Video();
            video1.Title = "The Dark Knight";
            video1.Genre = "Action";
            Id = Id++;
            videos.Add(video1);
            

            string[] menuItems =
            {
                
                "List all movies",
                "Add movie",
                "Delete movie",
                "Edit movie",
                "Exit",

            };

           var selection = ShowMenu(menuItems);

          
            
            while (selection !=5)
            {

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List of Movies");
                        ListVideos();
                        break;
                    case 2:
                        Console.WriteLine("Add Movie");
                        AddVideos();
                        break;
                    case 3:
                        Console.WriteLine("Delete Movie");
                        DeleteMovies();
                        break;
                    case 4:
                        Console.WriteLine("Edit Movie");
                        EditMovies();
                        break;
                    

                }

                selection = ShowMenu(menuItems);

            }
            Console.WriteLine("CYA");
            Console.ReadLine();           
           
        }

        private static void EditMovies()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovies()
        {
            var VideoFound = FindVideoById();
            if (VideoFound !=null)
            {
                videos.Remove(VideoFound);
            }
        }

        private static Video FindVideoById()
        { 
            Console.WriteLine("Insert Movie ID");

            foreach (var Video in videos)
            {
                if (Video.Id == Id)
                {
                    return Video;
                }
               
            }
            return null;
        }

        private static void ListVideos()
        {
            
        }

        private static int ShowMenu(string[] menuItems)
        {
            //Console.Clear();
            Console.WriteLine("Select what you want to do:\n");
            

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                 || selection < 1
                 || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            Console.WriteLine("Selection: " + selection);
            return selection;
            

        }
        private static void AddVideos()
        {
            Console.WriteLine("Enter a Title");
            var title = Console.ReadLine();
            Console.WriteLine("Enter a genre");
            var genre = Console.ReadLine();
            Id = Id++;
            videos.Add(new Video());
        }
        }
}
