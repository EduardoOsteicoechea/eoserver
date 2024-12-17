class Passage
{
   public string Reference { get; set; }
   public string BiblicalText { get; set; }
    public Passage(string reference, string biblicalText)
    {
        Reference = reference;
        BiblicalText = biblicalText;
    }
}
