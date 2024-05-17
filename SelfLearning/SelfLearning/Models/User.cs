using System;
using System.Collections.Generic;

namespace SelfLearning.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Avatar { get; set; }
    }
}
