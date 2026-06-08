using System;
using System.Collections.Generic;

class Song
{
    public string Title;

    public Song(string title)
    {
        Title = title;
    }
}

class Playlist
{
    public List<Song> songs = new List<Song>();

    public void AddSong(Song s)
    {
        songs.Add(s);
    }

    public void ShowSongs()
    {
        foreach (var s in songs)
        {
            Console.WriteLine(s.Title);
        }
    }
}

class Program
{
    static void Main()
    {
        Playlist p = new Playlist();

        p.AddSong(new Song("Song1"));
        p.AddSong(new Song("Song2"));

        p.ShowSongs();
    }
}
