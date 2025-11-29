using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C#", "Max Tidwell", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Can you cover LINQ next?"));

        Video video2 = new Video("D&D Dungeon Design", "DungeonMasterDan", 1200);
        video2.AddComment(new Comment("Eve", "Loved the atmosphere ideas."));
        video2.AddComment(new Comment("Frank", "This gave me inspiration for my campaign."));
        video2.AddComment(new Comment("Grace", "Could you share maps too?"));

        Video video3 = new Video("Python GUI Basics", "CodeWithMax", 900);
        video3.AddComment(new Comment("Hannah", "Tkinter looks simple!"));
        video3.AddComment(new Comment("Ian", "I prefer PyQt, but this is nice."));
        video3.AddComment(new Comment("Jack", "Can you show file handling next?"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display info for each video
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}