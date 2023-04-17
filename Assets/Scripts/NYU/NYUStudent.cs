using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUStudent : NYUPerson
{
    public float GPA = 4.0f;
    public int credits = 0;

    public NYUStudent(
        string _name, string _netId,
        float _gpa, int _credits) :
        base(_name, _netId)//it means that we are extending from what we got from NYUPerson
    {
        this.GPA = _gpa;
        this.credits = _credits;

        type = "NYU Student";//and it can be used directly because we have extended it
    }

    public override string ShowRecord()
    {
        //return "lol, i overrode your class you've been powned";
        return base.ShowRecord() + "GPA:" + GPA;
    }
}
