using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class SocialNetwork
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// Displays the options for the user to select from. Repeatedly displays them after
        /// user makes an action until user wants to quit
        /// </summary>
        public void DisplayMenu()
        {
            bool exit = false;
            do
            {
                ConsoleHelper.OutputHeading("SOCIALI NETWORK");

                string[] choices = new string[] { "ADD MESSAGE", "ADD PHOTO", "DISPLAY ALL POSTS", "DISPLAY USER POSTS", "DELTE POSTS", "ADD COMMENT", "LIKE A POST", "UNLIKE POST", "EXIT" };
                int choice = ConsoleHelper.SelectChoice(choices);

                
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostPhoto(); break;
                    case 3: DisplayPosts(); break;
                    case 4: DisplayAuthorPosts(); break;
                    case 5: DeletePost(); break;
                    case 6: AddComment(); break;
                    case 7: LikePost(); break;
                    case 8: UnlikePost(); break;
                    case 9: exit = true; break;
                }
            } while (!exit);
        }

        
        
        // to post message and print questions to answer
        // ie. whos the author, whats the message etc.
        public void PostMessage()
        {
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the author of the post");
            string author = Console.ReadLine();
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the message that you want to post");
            string message = Console.ReadLine();

            MessagePost messagePost = new MessagePost(author, message);
            news.AddPost(messagePost);
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("The below post was added");
            messagePost.Display();
        }


        // displays all posts- bearinmg in mind all posts are saved.

        public void DisplayPosts()
        {
            news.Display();
        }


        // to post a photo, (wont actually post photo, but the URL of it)

        public void PostPhoto()
        {
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the author of the post");
            string author = Console.ReadLine();
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the filename of the photo");
            string filename = Console.ReadLine();
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the caption of the photo");
            string caption = Console.ReadLine();

            PhotoPost photoPost = new PhotoPost(author, filename, caption);
            news.AddPost(photoPost);
            
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("The below post was added");
            
            photoPost.Display();
        }

        

        /// <summary>
        /// Displays posts of specifc user
        /// </summary>
        public void DisplayAuthorPosts()
        {
            
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the author's posts that you would like to look at");
            string author = Console.ReadLine();
            foreach (Post post in news.Posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                }
            }
        }

        /// <summary>
        /// Deletes a post by ID number.
        /// </summary>
        public void DeletePost()
        {
            DisplayPosts();
            int number = (int)ConsoleHelper.InputNumber("Enter the post number that you would like to delete : ", 1, news.Posts.Count);

            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("You will remove the below post");
            news.Posts[number - 1].Display();
            
            news.Posts.RemoveAt(number - 1);
        }


        /// <summary>
        /// Adds a like to a post. displays the *increment by 1
        /// </summary>
        public void LikePost()
        {
            DisplayPosts();
            int number = (int)ConsoleHelper.InputNumber("Enter the post number that you would like to like : ", 1, news.Posts.Count);

            news.Posts[number - 1].Like();
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("You have liked the below post");
            // this displays the liked post w/ new additional like
            news.Posts[number - 1].Display();
        }

        /// <summary>
        /// Removes a like from a post. User selects which post by its number
        /// </summary>
        public void UnlikePost()
        {
            DisplayPosts();
            int number = (int)ConsoleHelper.InputNumber("Enter the post number that you would like to unlike : ", 1, news.Posts.Count);

            news.Posts[number - 1].Unlike();
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("You have unliked the below post");
            news.Posts[number - 1].Display();
        }

        /// <summary>
        /// To add a comment, list displayed and then you have to select which toadd
        /// 
        /// </summary
        public void AddComment()
        {
            DisplayPosts();
            int number = (int)ConsoleHelper.InputNumber("Enter the post number that you would like to add a commnent to : ", 1, news.Posts.Count);

            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("You will comment on the below post");
            news.Posts[number - 1].Display();
            Console.WriteLine("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
            Console.WriteLine("Enter the comment that you would like to add");
            string text = Console.ReadLine();
            news.Posts[number - 1].AddComment(text);
        }
    }
}
