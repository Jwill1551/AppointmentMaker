using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {

        public AppointmentModel()
        {

        }

        public AppointmentModel(string patientName, DateTime dataTime, decimal patientNetWorth, string doctorName, int painLevel, string street, string city, int zIPcode, string email, string phone)
        {
            this.Street = street;
            this.City = city;
            this.ZIPcode = zIPcode;
            this.Email = email;
            this.Phone = phone;
        }

        [Required]
        [DisplayName("Patient's Full Name")]
        [StringLength(20, MinimumLength = 4)]
        public string patientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime dataTime { get; set; }

        [Required]
        [DisplayName("Patient's approximate net worth")]
        [DataType(DataType.Currency)]
        [Range(90000.00, 999999999, ErrorMessage = "Doctors refuse to see patients unless their net worth is more than $90000.00")]
        public decimal PatientNetWorth { get; set; }

        [Required]
        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Required]
        [Range(5,10, ErrorMessage = "Doctors refuse to see patients unless their pain level is above a 5")]
        [DisplayName("Patient's perceived level of pain (1 low to 10 high)")]
        public int PainLevel { get; set; }

        [Required]
        [DisplayName("Your Street Address")]
        public string Street { get; set; }

        [Required]
        [DisplayName("Your City")]
        public string City { get; set; }

        [Required]
        [DisplayName("Your Zipcode")]
        public int ZIPcode { get; set; }

        [Required]
        [DisplayName("Your Email Address")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Your Phone Number")]
        public string Phone { get; set; }


    }
}
