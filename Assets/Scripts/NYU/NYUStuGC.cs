using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUStuGC : NYUStudent
{
    public string favGame;
    
    public NYUStuGC(string _name, string _netId, float _gpa, int _credits, string favGame) : base(_name, _netId, _gpa, _credits)
    {
        this.favGame = favGame;
        type = "NYU Student - Game Design";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nFavourite Game:" + favGame;
    }
}
