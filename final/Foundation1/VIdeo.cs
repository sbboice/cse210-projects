class Video
{
    public string _title = "";
    public string _author = "";
    public int _length;
    public string _videoInfo = "";
    public List<string> _comments = new List<string>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _videoInfo = _title + ", posted by " + _author + ". Length: " + _length + " seconds.";
    }

    public void GetComments(string a1, string a2, string a3, string t1, string t2, string t3)
    {
        Comment c1 = new Comment(a1, t1);
        _comments.Add(c1._fullComment);

        Comment c2 = new Comment(a2, t2);
        _comments.Add(c2._fullComment);

        Comment c3 = new Comment(a3, t3);
        _comments.Add(c3._fullComment);
    }

    public void Display()
    {
        Console.WriteLine(_videoInfo);
        
        for (int i = 0; i < _comments.Count; i ++)
        {
            Console.WriteLine(_comments[i]);
        }

    }

}