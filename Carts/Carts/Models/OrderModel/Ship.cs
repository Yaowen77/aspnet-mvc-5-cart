using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carts.Models.OrderModel
{
    public class Ship
    {
        [Required]
        [Display(Name ="收貨人姓名")]
        [StringLength(30,ErrorMessage ="{0}的長度至少必須為{2}的字元。", MinimumLength = 2)]
        public string RecieverName { get; set; }

        [Required]
        [Display(Name = "收貨人電話")]
        [StringLength(15, ErrorMessage = "{0}的長度至少必須為{2}的字元。", MinimumLength = 8)]
        public string RecieverPhone { get; set; }

        [Required]
        [Display(Name = "收貨人住址")]
        [StringLength(256, ErrorMessage = "{0}的長度至少必須為{2}的字元。", MinimumLength = 8)]
        public string RecieverAdress { get; set; }
    }
}