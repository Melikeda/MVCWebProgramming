namespace BtkAkademi.Models
{
    public class Candidate
    {
        public string? EMail { get; set; } = string.Empty;  //Buradaki ? işareti C#’ta nullable reference type anlamına gelir. Yani bu değişken null olabilir demektir.

        public string? FirstName { get; set; } = string.Empty;

        public string? LastName { get; set; } = string.Empty;

        public string? FullName => $"{FirstName}{LastName?.ToUpper()}";

        public int? Age { get; set; }

        public string? SelectedCourse { get; set; } = string.Empty;

        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}