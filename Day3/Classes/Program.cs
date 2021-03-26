using System;
using System.Collections.Generic;

namespace Classes
{
    class Rect
    {
        int x;
        int y;
        public int width;
        public int height; 
        public int GetArea()
        {
            return width * height;
        }
        public int GetPerimeter()
        {
            return 2 * (width + height);
        }
        public void Move(int step){
            x = x + step;
            y = y + step;
        }

        public override string ToString(){
            return $"(x: {x}, y: {y})";
        } 
    }

    class Post
    {
        int likesCount = 0;
        public List<string> comments = new List<string>{};

        public void Like()
        {
            likesCount = likesCount + 1;
        }

        public int GetLikesNumber()
        {
            return likesCount;
        }

        public void LeaveComment(string comment)
        {
            comments.Add(comment);
        }
        string commentsList;
        public string GetComents()
        {
            foreach (string words in comments)
            {
                commentsList += " " + words;
            }

            return commentsList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();

            post.Like();
            Console.WriteLine(post.GetLikesNumber());
            post.Like();
            post.Like();
            post.Like();
            Console.WriteLine(post.GetLikesNumber());

            post.LeaveComment("I'm first!");
            Console.WriteLine(post.GetComents());
            post.LeaveComment("I'm second!");
            Console.WriteLine(post.GetComents());

            Console.WriteLine();

            Rect rect = new Rect();

            Console.WriteLine(rect.GetArea());
            Console.WriteLine(rect.GetPerimeter());

            rect.width = 5;
            rect.height = 5;
            Console.WriteLine(rect.GetArea());
            Console.WriteLine(rect.GetPerimeter());
            
            rect.width = 12;
            rect.height = 3;
            Console.WriteLine(rect.GetArea());
            Console.WriteLine(rect.GetPerimeter());

            Console.WriteLine(rect.ToString());

            rect.Move(5);
            Console.WriteLine(rect.ToString());
            rect.Move(5);
            Console.WriteLine(rect.ToString());
        }
    }

}
