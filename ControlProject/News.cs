using ControlProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class News
    {
        private NewsModel[] _newsList { get; set; }

        public News(NewsModel[] news)
        {
            _newsList = news;
        }
        public void View()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (var news in _newsList)
            {
                Console.WriteLine("{0}     {1}", news.Title, news.Content.Substring(0, news.Content.Length > 50 ? 50 : news.Content.Length));
            }
            Console.ResetColor();
        }

        public void Details(int num)
        {
            var news = _newsList[num];
            Console.WriteLine(news.Title);
            Console.WriteLine("");
            Console.WriteLine(news.Content);

            foreach (var comment in news.Comments)
            {
                Console.WriteLine("{0}|{1}: {2}", comment.Created, comment.Name, comment.Comment);
                Console.WriteLine("");
            }
        }

        public void CreateComment(int num)
        {
            var news = _newsList[num];
            var newComment = new CommentModel();
            Console.WriteLine("write your name");
            newComment.Name = Console.ReadLine();
            Console.WriteLine("Write comment");
            newComment.Comment = Console.ReadLine();
            newComment.Created = DateTime.Now;
            var comments = news.Comments;
            Array.Resize(ref comments, comments.Length + 1);
            comments[comments.Length-1] = newComment;
            news.Comments = comments;
        }
    }
}
