using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DomainModel;

public class Module
{
    string title;

    IList links;

    public Module(string title, IList links)
    {
        this.title = title;
        this.links = links;
    }

    public void goTo()
    {
        
    }
}