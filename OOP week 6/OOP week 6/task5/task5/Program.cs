using System;
using System.Collections.Generic;

class Comment
{
    public string Text;

    public Comment(string t)
    {
        Text = t;
    }
}

class Post
{
    public string Content;
    public List<Comment> comments = new List<Comment>();
    public int Likes = 0;

    public Post(string c)
    {
        Content = c;
    }

    public void AddComment(Comment c)
    {
        comments.Add(c);
    }

    public void Like()
    {
        Likes++;
    }

    public void Show()
    {
        Console.WriteLine("Post: " + Content);
        Console.WriteLine("Likes: " + Likes);
        foreach (var c in comments)
        {
            Console.WriteLine("Comment: " + c.Text);
        }
    }
}

class User
{
    public string Name;
    public List<Post> posts = new List<Post>();

    public User(string name)
    {
        Name = name;
    }

    public void CreatePost(Post p)
    {
        posts.Add(p);
    }
}

class Program
{
    static void Main()
    {
        User u = new User("Ali");

        Post p = new Post("Hello World");
        p.Like();
        p.AddComment(new Comment("Nice post"));

        u.CreatePost(p);

        p.Show();
    }
}