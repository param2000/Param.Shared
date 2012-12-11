using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Param.Shared.Core.Play
{
    public class GeneralViewModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Application Name is required.", AllowEmptyStrings = false)]
        public string AppName { get; set; }

        [RequiredForCompleteness]
        [DisplayName("Short Name")]
        public string AppAcronym { get; set; }


        [Required(ErrorMessage = "Application Version is required.", AllowEmptyStrings = false)]
        [RequiredForCompleteness]
        public string AppVersion { get; set; }
    }
}