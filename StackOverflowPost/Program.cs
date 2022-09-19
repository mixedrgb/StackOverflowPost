using System.Runtime.InteropServices;

namespace StackOverflowPost
{
    public class StackOverflowPost
    {
        private string _title = "Randomly generated title!";
        private string _description = "A description for the post in question.";
        private DateTime _dateCreated = DateTime.Today;
        private int _upvote = 0;

        private void Upvote()
        {
            _upvote++;
        }
        private void Downvote()
        {
            _upvote--;
        }

        private int TotalVotes()
        {
            return _upvote;
        }

        internal static void Main()
        {
            var post = new StackOverflowPost();
            Console.WriteLine("Title: {0}", post._title);
            Console.WriteLine("Description: {0}", post._description);
            for (int i = 0; i < 100000; i++)
            {
                var randNum = new Random().Next(1, 3);
                if (1 == randNum)
                {
                    post.Upvote();
                }
                else
                {
                    post.Downvote();
                }
            }
            Console.WriteLine("Total votes: {0}", post.TotalVotes());
        }
    }
}