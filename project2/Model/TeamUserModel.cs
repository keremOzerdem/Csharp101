public class TeamUserModel
{
    public TeamUserModel(int id,string username)
    {
        this.Id = id;
        this.Username = username;
    }

    public int Id { get; set; }
    public string Username { get; set;}
}