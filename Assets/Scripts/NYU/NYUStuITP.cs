using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUStuITP : NYUStudent
{
    public string favMachine;

    public NYUStuITP(string _name, string _netId, float _gpa, int _credits, string favMachine) : base(_name, _netId, _gpa, _credits)
    {
        this.favMachine = favMachine;
        type = "NYU Student - ITP";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nFavourite New Technology Machine:" + favMachine;
    }
}
