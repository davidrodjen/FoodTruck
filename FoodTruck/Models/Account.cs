using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    /// <summary>
    /// A single user account
    /// </summary>
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        /// <summary>
        /// The User's First Name
        /// </summary>
        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }

        /// <summary>
        /// The User's Last Name
        /// </summary>
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        /// <summary>
        /// The User's Delivery Address
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// The User's Email
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// The User's Phone Number
        /// </summary>
        public int PhoneNumber { get; set; }


        /// <summary>
        /// The User's Password
        /// </summary>
        [Required]
        [StringLength(150)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
