using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CarManager.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayname(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attribute = field?.GetCustomAttribute<DisplayAttribute>();

            return attribute?.Name ?? value.ToString();
        }
    }
}
