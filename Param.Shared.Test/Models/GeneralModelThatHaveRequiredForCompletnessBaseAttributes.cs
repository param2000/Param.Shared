using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Param.Shared.Core;

namespace Param.Shared.Test.Models
{
    public class GeneralModelThatHaveRequiredForCompletnessBaseAttributes
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Application Name is required.", AllowEmptyStrings = false)]
        public string AppName { get; set; }

        [RequiredForCompletnessInt(0)]
        [DisplayName("Short Name")]
        public int AppAcronym { get; set; }


        [Required(ErrorMessage = "Application Version is required.", AllowEmptyStrings = false)]
        [RequiredForCompletnessString(DisplayName = "App Version")]
        public string AppVersion { get; set; }
    }
}