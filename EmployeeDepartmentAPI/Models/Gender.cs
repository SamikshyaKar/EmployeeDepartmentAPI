using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Text.Json.Serialization;

namespace EmployeeDepartmentAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Male,
        Female,
        Other

    }
}
