using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSAddressBookMVC.Models
{
    public class Contact
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string City{ get; set; }
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        [NotMapped] //prevents entry into db
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }
        public byte[] ImageData { get; set; } //digital image as byte array
        public string ImageType { get; set; } //png, jpeg
        public int Id { get; set; } //db key
        [NotMapped] //prevents column in db
        public string FullName { get { return $"{FirstName} {LastName}"; } }  //no get or set


    }
}
