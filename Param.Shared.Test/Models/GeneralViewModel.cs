using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Param.Shared.Core;

namespace Param.Shared.Test.Models
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


    public class GeneralViewModelThatDoesNotHaveAnyAttributes
    {
        public string AppName { get; set; }
        public string AppAcronym { get; set; }
        public string AppVersion { get; set; }
    }
}