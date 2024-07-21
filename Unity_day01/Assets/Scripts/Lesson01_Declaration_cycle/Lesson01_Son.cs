using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01_Son : Lesson01_
{
    protected override void Awake()
    {
        base.Awake();
        print("子类的Awake");
    }
}
