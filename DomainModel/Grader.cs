using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DomainModel;

public class Grader
{
    float courseGrade;

    IList gradedWork;

    public Grader(float courseGrade, IList gradedWork)
    {
        this.courseGrade = courseGrade;
        this.gradedWork = gradedWork;s

    }
}