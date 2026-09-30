using System.ComponentModel.DataAnnotations;

namespace Hospital_Manager.ViewModels.Patient
{
    public class PatientDeleteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Първото име е задължително")]
        [MaxLength(30, ErrorMessage = " Допустими са само 30 символа"]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Фамилията е задължително")]
        [MaxLength(30, ErrorMessage = " Допустими са само 30 символа"]
        public string LastName { get; set; }
     
    }
}
