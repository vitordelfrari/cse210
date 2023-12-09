using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating videos
        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("User3", "Nice content!");
        video2.AddComment("User4", "Could be better.");

        Video video3 = new Video("Title 3", "Author 3", 150);
        video3.AddComment("User5", "Awesome explanation!");
        video3.AddComment("User6", "I have a question.");

        // Creating a list of videos
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // Displaying information for each video
        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine("\n");
        }
    }
}
