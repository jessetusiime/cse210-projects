using System.Collections.Generic;

public class Video
{
    public string Title;
    public string Creator;
    public int LengthInSeconds;

    public List<Comment> Comments = new List<Comment>();

    public Video(string title, string creator, int length)
    {
        Title = title;
        Creator = creator;
        LengthInSeconds = length;
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}
