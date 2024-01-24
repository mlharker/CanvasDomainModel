using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DomainModel;

public class Professor
{
    string name;
    string email;

    IList courses;

    public Professor(string name, string email, IList courses)
    {
        this.name = name;
        this.email = email;
        this.courses = courses;
    }
}