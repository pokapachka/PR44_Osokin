using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ПР44_Осокин.Classes.Database
{
    public class Config
    {
        public static readonly string connection = "server=localhost;uid=root;database=TaskManager;";
        public static readonly MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
