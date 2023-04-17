using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUStaff : NYUPerson
{
    public float salary = 10000000f;

    public NYUStaff(float _salary)
    {
        this.salary = salary;
    }

    public NYUStaff(string name, string netId, float salary) : base(name, netId)
    {
        this.salary = salary;
    }

    

    public override string ShowRecord()
    {
        return base.ShowRecord() + "Salary:" + salary;
    }
}
