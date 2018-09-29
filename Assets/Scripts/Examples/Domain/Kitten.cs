using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Kitten : EventArgs
{
    public string name;
    public int fluffinessLevel;

    public Kitten(string name, int fluffiness)
    {
        this.name = name;
        this.fluffinessLevel = fluffiness;
    }
}
