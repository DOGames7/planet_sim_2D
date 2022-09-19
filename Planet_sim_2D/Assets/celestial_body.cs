using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celests : MonoBehaviour
{
    public void Main(int x, int y, double radius, double mass)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
        this.mass = mass;
    }

    public double attraction(Celests other)
    {
        this.init();
        double other_x, other_y, distance_x, distance_y, distance;
        
        other_x = other.x;
        other_y = other.y;

        distance_x = other.x - this.x;
        distance_y = other.y - this.y;

        

    }
}

Celests celestial = new Celests(0, 0, 30, 1.98892 * Math.Pow(10, 30));

public static List celestials = new List();
celestials.Add(celestial);

Debug.Log(celestials);