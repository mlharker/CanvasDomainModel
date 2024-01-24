using System.Collections;
using System.Runtime.InteropServices;

namespace DomainModel;

public class User
{
    string name;
    string email;

    IList courses;

    public User(string name, string email, IList courses)
    {
        this.name = name;
        this.email = email;
        this.courses = courses;
    }
}
