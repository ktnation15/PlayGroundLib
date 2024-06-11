namespace PlayGroundLib
{
    public class PlayGround
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MaxChildren { get; set; }
        public int MinChildAge { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, MaxChildren: {MaxChildren}, MinAge: {MinChildAge}";
        }

    }
}
