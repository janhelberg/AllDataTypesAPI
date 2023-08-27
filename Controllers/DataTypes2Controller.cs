using Microsoft.AspNetCore.Mvc;
using System;

namespace DataTypesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataTypes2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get()
        {
            var response = new
            {
                Integer = new { DataType = "int", Value = 42 },
                Double = new { DataType = "double", Value = 3.14 },
                String = new { DataType = "string", Value = "Hello, World!" },
                Boolean = new { DataType = "bool", Value = true },
                DateTime = new { DataType = "DateTime", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff") },
                Guid = new { DataType = "Guid", Value = Guid.NewGuid() },
                Char = new { DataType = "char", Value = 'A' },
                Byte = new { DataType = "byte", Value = (byte)128 },
                Short = new { DataType = "short", Value = (short)30000 },
                Int = new { DataType = "int", Value = 1234567890 },
                Long = new { DataType = "long", Value = 1234567890123456789L },
                Float = new { DataType = "float", Value = 123.456f },
                Decimal = new { DataType = "decimal", Value = 123.4567890123456789M },
                TimeSpan = new { DataType = "TimeSpan", Value = TimeSpan.FromHours(2) },
                NullableInt = new { DataType = "int?", Value = (int?)null },
                Array = new { DataType = "int[]", Value = new int[] { 1, 2, 3 } },
                Object = new
                {
                    DataType = "object",
                    Value = new { Name = "Alice", Age = 30 }
                },
                Enum = new { DataType = "ConsoleColor", Value = ConsoleColor.Red.ToString() }
            };

            return Ok(response);
        }
    }
}
