using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Infos
    {
        public string prenom { get; set; }
        public string nom { get; set; }
        [RegularExpression(@"^(Homme|Femme|Autre)$", ErrorMessage = "Le genre doit être 'homme', 'femme' ou 'autre'.")]
        public string genre { get; set; }
        public string adresse { get; set; }
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "L'adresse postal doit être 5 chiffres.")]
        public string zipcode { get; set; }
        public string ville { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage= "Entrez une adresse valide.")]
        public string email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Range(typeof(DateTime),"01-01-0001","31-12-2020",
        ErrorMessage = "La date doit être avant le 1er janvier 2021.")]
        public DateTime startDate { get; set; }
        [RegularExpression(@"^(Cobol Training|Object Training|Dual Skills Training)$", 
            ErrorMessage = "Le type de formation doit être 'Cobol Training', 'Object Training' ou 'Dual Skills Training'.")]
        public string typetraining { get; set; }
        public string aviscb { get; set; }
        public string aviscs { get; set; }

    }
}
