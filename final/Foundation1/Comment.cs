class Comment
{
    public string _author = "";
    public string _text = "";
    public string _fullComment = "";

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
        _fullComment = _author + " says: " + _text;
    }
}