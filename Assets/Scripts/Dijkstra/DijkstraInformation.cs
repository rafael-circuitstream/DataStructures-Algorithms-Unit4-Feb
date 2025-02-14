using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Imagine this class as a line/row in a excel sheet containing the city, the shortest distance and the previous city
[System.Serializable]
public class DijkstraInformation
{
    public GraphNode cityNode;
    public float shortestDistanceTo;
    public GraphNode previousCityToGo;

}
