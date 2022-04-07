using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// ZARRAR AFZAL
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "sen7ry";
        public List<Post> Posts { get; }
        public int itemNumber;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "Meow");
            AddPost(post);
            PhotoPost photopost = new PhotoPost(AUTHOR, "cats.jpg", "Cats :D");
            AddPost(photopost);
        }

        /// Adds post to the 'news feed'
        /// When you display all posts it would show up
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

        ///<summary>
        /// Displays all the posts made
        ///</summary>
        public void Display()
        {
            // display all posts made
            foreach (var (item, index) in Posts.Select((value, i) => (value, i)))
            {
                itemNumber = index + 1;
                Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
                Console.WriteLine($" POST NO. {itemNumber}");
                item.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }
}
