using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Circle1
{
    Circle1 enemy = new Circle1(5, 5, 5);
    void Start()
    {
        enemy.CircleRadious = Random.Range((int)1, (int)11);
        enemy.CircleArea = 3.14 * (enemy.CircleRadious * enemy.CircleRadious);
        enemy.CirclePerimeter = 6.28 * enemy.CircleRadious;
    }
}