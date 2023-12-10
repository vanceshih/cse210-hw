using System;

class Program
{
    static void Main()
    {
        // Create videos and comments
        var video1 = new Video("Exploring Space", "John Astronaut", 615);
        video1.AddComment("SpaceExplorer42", "This is mind-blowing! The vastness of space is truly mesmerizing.");
        video1.AddComment("StellarObserver", "I wish I could witness these wonders in person. Amazing video!");
        video1.AddComment("CosmicDreamer", "The music choice enhances the experience. Well done!");
        video1.AddComment("GalacticAdventurer", "This video inspires me to learn more about space exploration. Thank you!");

        var video2 = new Video("Healthy Cooking Tips", "Chef Wellness", 303);
        video2.AddComment("FoodieForever", "These tips are so practical and easy to follow. Thanks for sharing!");
        video2.AddComment("FitKitchen", "I've been looking for ways to make my meals healthier. Great advice!");
        video2.AddComment("NutritionEnthusiast", "The explanation about portion control was eye-opening. Very informative.");

        var video3 = new Video("Introduction to Robotics", "RoboTech Geek", 482);
        video3.AddComment("TechEnthusiast101", "I've always been fascinated by robotics. This video is a great introduction!");
        video3.AddComment("FutureEngineer", "The explanation of different types of robots was really helpful. Excited to learn more!");
        video3.AddComment("RoboticsNerd", "I appreciate the historical context provided. It adds depth to the subject.");
        video3.AddComment("AIExplorer", "The potential applications of robotics are limitless. Great content!");


        // Put videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
