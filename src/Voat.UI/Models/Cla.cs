#region LICENSE

/*
    
    Copyright(c) Voat, Inc.

    This file is part of Voat.

    This source file is subject to version 3 of the GPL license,
    that is bundled with this package in the file LICENSE, and is
    available online at http://www.gnu.org/licenses/gpl-3.0.txt;
    you may not use this file except in compliance with the License.

    Software distributed under the License is distributed on an
    "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express
    or implied. See the License for the specific language governing
    rights and limitations under the License.

    All Rights Reserved.

*/

#endregion LICENSE

using System.ComponentModel.DataAnnotations;

namespace Voat.Models
{
    public class Cla
    {
        [Required(ErrorMessage = "Full name is required.")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mailing address is required.")]
        public string MailingAddress { get; set; }
        
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }        

        [Required(ErrorMessage = "Phone number is required.")]
        public string PhoneNumber { get; set; }
        public string CorpContrInfo { get; set; }

        [Required(ErrorMessage = "Type \"I AGREE\" to accept the terms above.")]
        public string ElectronicSignature { get; set; }
    }
}
