using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{

    int chooseFigure;
    Circle showCircle = new Circle(0, 10);
    Square showSquare = new Square(8, 10);
    Rectangule showRectangule = new Rectangule(8, 10, 5);
    Triangle showTriangle = new Triangle(5, 10);

    private void Start()
    {

    }

    public void ChooseFigure()
    {
        chooseFigure = Random.Range(1, 5);
        if (chooseFigure == 1)
        {
            Debug.Log("Has elegido un circulo con estas specs: numero de vertices: " + showCircle.numberOfEdges + " Y radio: " + showCircle.radious);
        }
        if (chooseFigure == 2)
        {
            Debug.Log("Has elegido un cuadrado con estas specs: numero de vertices: " + showSquare.numberOfEdges + " Y largo de lado " + showSquare.sideLenght);
        }
        if (chooseFigure == 3)
        {
            Debug.Log("Has elegido un rectangulo con estas specs: numero de vertices " + showRectangule.numberOfEdges + ",  largo de la base " + showRectangule.baseLenght + " y altura " + showRectangule.heightLenght);
        }
        if (chooseFigure == 4)
        {
            Debug.Log("Has elegido un rectangulo con estas specs: numero de vertices " + showTriangle.numberOfEdges + " y altura " + showTriangle.sideLength);
        }
    }
}

