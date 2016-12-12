using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject.Model
{
    class NewsModel
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public CommentModel[] Comments { get; set; }

    }
}
