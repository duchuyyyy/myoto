﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyOToVer1._2.Models
{
    public class Owner
    {
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public double owner_revenue { get; set; }
        [Required(ErrorMessage = "Trường này không được bỏ trống")]
        public string  owner_number_account { get; set; }
        [Required(ErrorMessage = "Trường này không được bỏ trống")]
        public  string owner_name_banking { get; set; }

        public int owner_status { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<OwnerIdentityPhoto> ownerIdentityPhotos { get; set; }
    }
}
