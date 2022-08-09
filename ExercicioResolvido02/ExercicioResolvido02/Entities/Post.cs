using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido02.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }

        public string Content { get;  set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine(Title);
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine(Moment.ToString("D"));
            sb.AppendLine("\n" + Content + "");
            sb.Append(Likes+ " Likes\n\n-------------------\nComments:\n-------------------\n");

            foreach(Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }



            return sb.ToString();
        }
    }
}
