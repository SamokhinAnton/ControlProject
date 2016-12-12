using ControlProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = true;
            var newsList = new NewsModel[] 
            {
                new NewsModel() {Content = "content news 1 content news 1content news 1content news 1content news 1content news 1content news 1content news 1content news 1content news 1content news 1content news 1content news 1content news 1", Title="title 1", Comments = new CommentModel[] { new CommentModel() { Comment="Comment 1", Name="name 1", Created = new DateTime(2016, 10, 10, 5, 15, 10 )} } },
                new NewsModel() {Content = "content news 2", Title="title 2", Comments = new CommentModel[] { new CommentModel() { Comment="Comment 2", Name = "name 1", Created = new DateTime(2016, 10, 10, 5, 15, 10 )} } },
                new NewsModel() {Content = "content news 3", Title="title 2", Comments = new CommentModel[] { new CommentModel() { Comment="Comment 3", Name = "name 1", Created = new DateTime(2016, 10, 10, 5, 15, 10 )} } }
            };
            while (check)
            {
                var news = new News(newsList);
                news.View();
                Console.WriteLine("Choose news index");
                var index = int.Parse(Console.ReadLine());
                news.Details(index);
                Console.WriteLine("type c to add comment or b to go back to the list");
                var action = Console.ReadLine().ToLower();
                switch (action)
                {
                    case "c":
                        news.CreateComment(index);
                        break;
                    case "b":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }

         }
    }
}
