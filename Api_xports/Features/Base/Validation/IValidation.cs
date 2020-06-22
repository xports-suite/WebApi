using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.Validation
{
    ///
    public interface IValidation
    {
        ///
        IEnumerable<ValidationResult> GetValidationsErrors();
        ///
        bool HasValidationErrors();
    }
}
