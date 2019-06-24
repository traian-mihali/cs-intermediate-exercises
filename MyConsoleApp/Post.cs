using System;

namespace MyConsoleApp
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; }

        public Post()
        {
            Created = DateTime.Now;
        }

        public void UpVotePost()
        {
            Vote++;
        }

        public void DownVotePost()
        {
            if (Vote < 1)
                throw new ArgumentOutOfRangeException();
            Vote--;
        }

        public int Vote { get; private set; }
    }
}