using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DomainModel;

public class Task
{
    string assignment;
    string announcement;

    public Task(string assignment, string announcement)
    {
        this.assignment = assignment;
        this.announcement = announcement;
    }
}