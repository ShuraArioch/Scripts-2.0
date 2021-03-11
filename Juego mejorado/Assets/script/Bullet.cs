using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Circle1
{
    Circle1 bullet = new Circle1(5, 5, 5);
    void Start()
    {
        bullet.CircleRadious = Random.Range((int)1, (int)11);
        bullet.CircleArea = 3.14 * (bullet.CircleRadious * bullet.CircleRadious);
        bullet.CirclePerimeter = 6.28 * bullet.CircleRadious;
    }
}
