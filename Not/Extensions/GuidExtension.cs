using System;
namespace Not
{
    public static class GuidExtension
    {
        public static bool IsNotEmpty(this Guid value)
        {
            return value != Guid.Empty;
        }
    }
}
