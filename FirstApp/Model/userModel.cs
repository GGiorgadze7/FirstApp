namespace FirstApp.Model;

public class userModel
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string GetFullName()
    {
        return Name + " " + Surname;
    }
}
