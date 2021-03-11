using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Circle1
{
    Circle1 coin = new Circle1(5, 5, 5);
    void Start()
    {
        coin.CircleRadious = Random.Range((int)1, (int)11);
        coin.CircleArea = 3.14*(coin.CircleRadious*coin.CircleRadious);
        coin.CirclePerimeter = 6.28 * coin.CircleRadious;
    }
}