using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; }
    public string Text { get; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    private List<Comment> Comments { get; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(Comments);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to Cook Pasta", "ChefAlex", 540);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Very easy to follow."));
        video1.AddComment(new Comment("Charlie", "Yummy!"));

        var video2 = new Video("Guitar Tutorial for Beginners", "MusicMan", 720);
        video2.AddComment(new Comment("Dave", "Awesome lesson."));
        video2.AddComment(new Comment("Eve", "Thanks for the tips!"));
        video2.AddComment(new Comment("Frank", "Can't wait to practice this."));

        var video3 = new Video("Top 10 Travel Destinations", "Wanderlust", 600);
        video3.AddComment(new Comment("Grace", "I want to visit all of these!"));
        video3.AddComment(new Comment("Heidi", "Nice picks!"));
        video3.AddComment(new Comment("Ivan", "Beautiful places."));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}