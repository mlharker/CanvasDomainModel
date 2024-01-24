using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DomainModel;

public class Announcement
{
    string title;
    string body;

    public Announcement(string title, string body)
    {
        this.title = title;
        this.body = body;
    }
}