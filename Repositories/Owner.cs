namespace DogGo.Repositories
{
    internal class Owner
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int NeighborhoodId { get; internal set; }
        public string Email { get; internal set; }
        public string Address { get; internal set; }
        public int Phone { get; internal set; }
    }
}