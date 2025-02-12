using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphEdge : MonoBehaviour
{
    [SerializeField] private GraphNode nodeA;
    [SerializeField] private GraphNode nodeB;
    [SerializeField] private LineRenderer lineRenderer;

    public float distanceBetweenNodes;
    // Start is called before the first frame update
    void Start()
    {
        distanceBetweenNodes = Vector3.Distance(nodeA.transform.position, nodeB.transform.position);
        lineRenderer.SetPosition(0, nodeA.transform.position);
        lineRenderer.SetPosition(1, nodeB.transform.position);

        nodeA.connectedNodes.Add(this);
        nodeB.connectedNodes.Add(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
