using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle
{
    public int numberOfEdges;
    public int radious;

    public Circle(int anumberOfEdges, int aradious)
    {
        numberOfEdges = anumberOfEdges;
        radious = aradious;
    }


}

public class Circle1
{
    private int circleRadious;
    private double circleArea;
    private double circlePerimeter;

    public Circle1(int acircleRadious, double acircleArea, double acirlcePerimeter)
    {
        circleRadious = acircleRadious;
        circleArea = acircleArea;
        circlePerimeter = acirlcePerimeter;
    }

    public int CircleRadious
    {
        get { return circleRadious; }
        set { circleRadious = value; }
    }
    public double CircleArea
    {
        get { return circleArea; }
        set { circleArea = value; }
    }
    public double CirclePerimeter
    {
        get { return circlePerimeter; }
        set { circlePerimeter = value; }
    }
    public Circle1()
    {

    }
}

