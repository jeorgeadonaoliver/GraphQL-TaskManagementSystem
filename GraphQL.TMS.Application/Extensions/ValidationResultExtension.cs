using FluentValidation.Results;

namespace GraphQL.TMS.Application.Extensions
{
    public static class ValidationResultExtension
    {
        public static void CheckResult(this ValidationResult result) 
        {
            if (result.Errors.Any())
            {
                var errorMessages = string.Join("; ", result.Errors.Select(e => e.ErrorMessage));
                throw new Exception(errorMessages);
            }
        }
    }
}
