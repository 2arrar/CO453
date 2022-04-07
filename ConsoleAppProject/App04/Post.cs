using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// baseplate class for photopost and messagepost class
    /// </summary>
    public class Post
    {
        public List<String> comments;
        public int likes;
        public String Username { get; set; }
        public DateTime Timestamp { get; set; }
        public Post(String author)
        {
            this.Username = author;
            Timestamp = DateTime.Now;
            likes = 0;
            comments = new List<String>();
        }

        ///<summary>
        /// adds a like by increment of 1
        ///</summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// if likes are bigger than 0, remove by increment of 1
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        ///</summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// displays details about post username,like
        ///  time elapsed etc.
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    AUTHOR: {Username}");
            Console.WriteLine($"    TIME ELAPSED: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    LIKES:  {likes}  ");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    NO COMMENTS MADE");
            }
            else
            {
                Console.WriteLine($"    COMMENT SECTION: {comments.Count}  VIEW?");
            }
        }


        /// <summary>
        /// Displays eklapsed time of post
        /// eg. 20secs elapsed
        /// </summary>
        /// <param name="time">
        /// The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>  
        public String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;
            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " MINTES AGO";
            }
            else
            {
                return seconds + " MINUTES AGO";
            }
        }


    }
}
