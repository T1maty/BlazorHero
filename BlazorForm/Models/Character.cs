namespace BlazorForm.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } =  string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Image { get; set; } = string.Empty;
        public int TeamId { get; set; } = 1;
        public int DifficultyId { get; set; } = 1;
        public bool IsReadyToFight { get; set; } = true;
    }
}
