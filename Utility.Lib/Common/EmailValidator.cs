using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Utility.Lib.Common
{
    internal sealed class EmailValidator
    {
        public static ValidationResult Validate(string email, ValidationContext context)
        {
            // Implement your email validation logic here
            // Return ValidationResult.Success if valid, otherwise return an appropriate ValidationResult

            if (Regex.IsMatch(email, AppConstants.EMAIL_VALIDATION_REGEX))
                return ValidationResult.Success;

            return new ValidationResult("Invalid email format", new[] { context.MemberName });
        }
    }
}
