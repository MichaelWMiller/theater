namespace theater.Models
{
  public class User
  {
    public string Name { get; set; }

    private string _password;

    public bool ValidatePassword(string password)
    {
      if (password == _password)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public User(string name, string password)
    {
      Name = name;
      _password = password;
    }

  }
}