using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video v1 = new Video("Master debits and credits in accounting", "Jahz", 560);
        Video v2 = new Video("Learn Javascript in 30 Minutes", "Codex", 900);
        Video v3 = new Video("Cooking Ugandan Rolex", "Chef Godwin", 430);

        // Comments for the videos
        v1.Comments.Add(new Comment("Alice", "Great explanation!"));
        v1.Comments.Add(new Comment("Mark", "Thanks for the video."));
        v1.Comments.Add(new Comment("Sarah", "Very helpful, appreciate it"));

        v2.Comments.Add(new Comment("Peter", "Fast and clear and on point!"));
        v2.Comments.Add(new Comment("Linda", "This helped me in class."));
        v2.Comments.Add(new Comment("Chris", "Amazing tutorial."));

        v3.Comments.Add(new Comment("John", "Looks delicious."));
        v3.Comments.Add(new Comment("Grace", "This recipe is perfect!"));
        v3.Comments.Add(new Comment("David", "I tried it today, it's awesome!"));

        List<Video> videos = new List<Video>() { v1, v2, v3 };

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Creator}");
            Console.WriteLine($"Length: {v.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($" {c._commenterName}: {c._text}");
            }

            Console.WriteLine();
        }
        }
}