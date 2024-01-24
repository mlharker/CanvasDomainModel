using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DomainModel;

public class Assignment
{
    string title;
    string instructions;

    float grade;

    public Assignment(string title, string instructions, float grade)
    {
        this.title = title;
        this.instructions = instructions;
        this.grade = grade;
    }

    public void submit()
    {
        
    }
}