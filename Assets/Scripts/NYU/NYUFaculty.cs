using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUFaculty : NYUStaff
{
    private string className;

    public NYUFaculty(string name, string netId, float salary, string className) : base(name, netId, salary)
    {
        this.className = className;
        type = "NYU Faculty";
    }

    

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nClass Name:" + className;
    }
}
