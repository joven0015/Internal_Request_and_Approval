using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Role { get; set; } = "Employee";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}


// 1. Install dependencies
// Run this command to install the required dependencies.
// Code:
// File: Code
// ```
// dotnet add package Microsoft.Extensions.Configuration.Json --version YOUR_DOTNET_VERSION
// ```

// 2. Add files
// Add the following files to your project.
// Details:
// host:db.kedhcipktjihhtzdqdoi.supabase.co
// port:5432
// database:postgres
// user:postgres
// Add the configuration package to read the settings.
// Code:
// File: appsettings.json
// ```
// 1{
// 2  "ConnectionStrings": {
// 3    "DefaultConnection": "Host=db.kedhcipktjihhtzdqdoi.supabase.co;Database=postgres;Username=postgres;Password=[YOUR-PASSWORD];SSL Mode=Require;Trust Server Certificate=true"
// 4  }
// 5}
// ```

// File: Code
// ```
// dotnet add package Microsoft.Extensions.Configuration.Json --version YOUR_DOTNET_VERSION
// ```

// 3. Install Agent Skills (Optional)
// Agent Skills give AI coding tools ready-made instructions, scripts, and resources for working with Supabase more accurately and efficiently.
// Details:
// npx skills add supabase/agent-skills
// Code:
// File: Code
// ```
// npx skills add supabase/agent-skills
// ```