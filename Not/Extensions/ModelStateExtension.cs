using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Not
{
    public static class ModelStateExtension
    {
        public static bool IsNotValid(this ModelStateDictionary modelState)
        {
            return !modelState.IsValid;
        }
    }
}