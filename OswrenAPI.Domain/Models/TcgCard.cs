namespace OswrenAPI.Domain.Models
{
    public class TcgCard
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Set { get; set; }
        public int SetNumber { get; set; }
        public string Rarity { get; set; }
        public string SetNumberString { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public bool Foil { get; set; }

        public TcgCard Clone()
        {
            return new TcgCard
            {
                Id = this.Id,
                Name = this.Name,
                Text = this.Text,
                Set = this.Set,
                SetNumber = this.SetNumber,
                Rarity = this.Rarity,
                SetNumberString = this.SetNumberString,
                ImageUrl = this.ImageUrl,
                Type = this.Type,
                Foil = this.Foil
            };
        }
    }
}
