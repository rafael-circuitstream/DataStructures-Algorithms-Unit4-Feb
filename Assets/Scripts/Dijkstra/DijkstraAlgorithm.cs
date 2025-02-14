using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DijkstraAlgorithm : MonoBehaviour
{
   
    [SerializeField] private List<DijkstraInformation> cities;  //ALL CITIES / THE EXCEL TABLE
    [SerializeField] private GraphNode startingNode; //City to start

    //Filter for cities that we already checked/visited and cities that we are yet to visit
    private List<DijkstraInformation> unvisitedCities = new List<DijkstraInformation>();
    private List<DijkstraInformation> visitedCities = new List<DijkstraInformation>();


    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            DoDijkstraAlgorithm(GetInformationOnTableFromGraphNode(startingNode, cities));
        }
    }


    private void DoDijkstraAlgorithm(DijkstraInformation startingNode)
    {
        unvisitedCities.AddRange(cities);

        //Initialize all cities with distance to Infinity, if the city is the one we start, then initialize distance with 0
        foreach(DijkstraInformation city in unvisitedCities)
        {
            if(city == startingNode)
            {
                city.shortestDistanceTo = 0;
            }
            else
            {
                city.shortestDistanceTo = Mathf.Infinity;
            }
        }

        //While we have cities to visit
        while (unvisitedCities.Count > 0)
        {
            //Get unvisited city with shortest distance
            DijkstraInformation currentCity = GetCityInfoWithShortestDistance(unvisitedCities); 

            //For every neighbour of the currentCity
            foreach (GraphNode neighbour in currentCity.cityNode.connectedNodes)
            {
                /*First, access the information of the table about this neighbour */ DijkstraInformation infoAboutNeighbour = GetInformationOnTableFromGraphNode(neighbour, unvisitedCities);

                if (infoAboutNeighbour != null) //If this neighbour is unvisited
                {
                    float distanceToNode = Vector3.Distance(neighbour.transform.position, currentCity.cityNode.transform.position); //Calculate distance between neighbour game object and current city game object
                    if (distanceToNode < cities[cities.IndexOf(infoAboutNeighbour)].shortestDistanceTo) //If the distance found is lower than the one in the table
                    {
                        //Update the information
                        infoAboutNeighbour.shortestDistanceTo = distanceToNode + currentCity.shortestDistanceTo; //Sum distance to current city + distance to neighbour
                        infoAboutNeighbour.previousCityToGo = currentCity.cityNode; //Update the previous city to go
                    }
                }
            }

            //Update filters of Unvisited and Visited
            unvisitedCities.Remove(currentCity);
            visitedCities.Add(currentCity);
        }



    }

    //This method find the item/element/"row" in the "table" that has the lowest "shortestDistanceTo"
    private DijkstraInformation GetCityInfoWithShortestDistance(List<DijkstraInformation> cityInfos)
    {
        float lowestDistance = Mathf.Infinity;
        DijkstraInformation infoWithLowestDistance = null;
        foreach(DijkstraInformation info in cityInfos)
        {
            if(info.shortestDistanceTo < lowestDistance)
            {
                lowestDistance = info.shortestDistanceTo;
                infoWithLowestDistance = info;
                //info is now the city with lowest distance
            }
        }

        return infoWithLowestDistance;
    }


    //This method find the item/element/"row" in the "table" that contains the City we are trying to find
    private DijkstraInformation GetInformationOnTableFromGraphNode(GraphNode nodeToFind, List<DijkstraInformation> cityInfos)
    {
        foreach(DijkstraInformation info in cityInfos)
        {
            if(info.cityNode == nodeToFind)
            {
                return info;
            }
        }

        return null;
    }

}
