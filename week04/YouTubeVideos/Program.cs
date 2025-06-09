using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Carlos Méndez", 480);
        video1.AddComment(new Comment("Ana", "Muy útil, gracias!"));
        video1.AddComment(new Comment("Luis", "Excelente explicación."));
        video1.AddComment(new Comment("Clara", "Me ayudó mucho para mi tarea."));

        Video video2 = new Video("Mate Tutorial", "Sofía Ríos", 320);
        video2.AddComment(new Comment("Pedro", "Viva el mate!"));
        video2.AddComment(new Comment("Lucía", "Me encantó este video."));
        video2.AddComment(new Comment("Juan", "Muy bien explicado."));

        Video video3 = new Video("Receta de Empanadas", "Martín Suárez", 600);
        video3.AddComment(new Comment("Camila", "Voy a probar esta receta."));
        video3.AddComment(new Comment("Gabriel", "¡Riquísimas!"));
        video3.AddComment(new Comment("Noelia", "Me encantó."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}