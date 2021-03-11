using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partner : Circle1
{
    Circle1 partner = new Circle1(5, 5, 5);
    void Start()
    {
        partner.CircleRadious = Random.Range((int)1, (int)11);
        partner.CircleArea = 3.14 * (partner.CircleRadious * partner.CircleRadious);
        partner.CirclePerimeter = 6.28 * partner.CircleRadious;
    }
}