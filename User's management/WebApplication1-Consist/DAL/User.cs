using System;
using System.Collections.Generic;

namespace WebApplication1_Consist.DAL;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public User(string UserName, string UserPassword)
    {
        UserName = UserName;
        UserPassword = UserPassword;        
    }

    public User()
    {
        
    }
}
