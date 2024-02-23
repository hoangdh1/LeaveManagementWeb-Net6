using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation Period")]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}