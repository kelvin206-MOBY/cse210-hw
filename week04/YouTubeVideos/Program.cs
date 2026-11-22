using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "Introduction to C#",
            "Kelvin",
            600
        );

        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Mary", "I learned something new."));
        video1.AddComment(new Comment("David", "Very helpful video!"));


        // Create the second video
        Video video2 = new Video(
            "Learning Python",
            "Tech Academy",
            850
        );

        video2.AddComment(new Comment("Sarah", "Python is interesting."));
        video2.AddComment(new Comment("Peter", "Thanks for sharing."));
        video2.AddComment(new Comment("James", "I enjoyed this lesson."));
        video2.AddComment(new Comment("Grace", "Please make more videos."));


        // Create the third video
        Video video3 = new Video(
            "Web Development for Beginners",
            "Code Master",
            1200
        );

        video3.AddComment(new Comment("Michael", "This was very useful."));
        video3.AddComment(new Comment("Daniel", "I love web development."));
        video3.AddComment(new Comment("Esther", "Great tutorial!"));


        // Create the fourth video
        Video video4 = new Video(
            "Introduction to JavaScript",
            "Programming School",
            950
        );

        video4.AddComment(new Comment("Alex", "JavaScript is powerful."));
        video4.AddComment(new Comment("Linda", "Very clear explanation."));
        video4.AddComment(new Comment("Samuel", "I learned a lot."));
        video4.AddComment(new Comment("Joy", "Looking forward to the next lesson."));


        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        // Display all videos and their comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}