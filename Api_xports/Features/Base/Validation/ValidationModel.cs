using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.Validation
{
    ///
    public class ValidationModel : IValidation
    {
        ///
        internal List<ValidationResult> ValidationResults { get; set; } = new List<ValidationResult>();
        ///
        public ValidationModel() { }
        ///
        public ValidationModel(List<ValidationResult> validationResults)
        {
            ValidationResults = validationResults;
        }
        ///
        public IEnumerable<ValidationResult> GetValidationsErrors()
        {
            return ValidationResults;
        }
        ///
        public bool HasValidationErrors()
        {
            return ValidationResults.Count > 0;
        }

        internal virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return ValidationResults;
        }
    }
}
