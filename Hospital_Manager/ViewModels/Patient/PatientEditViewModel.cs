using System.ComponentModel.DataAnnotations;

namespace Hospital_Manager.ViewModels.Patient
{
    public class PatientEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Първото име е задължително")]
        [MaxLength(30, ErrorMessage = " Допустими са само 30 символа"]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Фамилията е задължително")]
        [MaxLength(30, ErrorMessage = " Допустими са само 30 символа"]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Имейла е задължително")]
        [EmailAddress(ErrorMessage = "Трябва да има синтаксис на имейл")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Телефоният номер е задължително")]
        [Phone(ErrorMessage = "Трябва да има синтаксис на телефонен номер")]
        public string PhoneNumber { get; set; }
    }
}
