using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    [SerializeField] private GameObject hitDebug;
    [SerializeField] private int accuracy;
    [SerializeField] private LayerMask mask;
    Mesh fog;
    // Start is called before the first frame update
    void Start()
    {

        fog = new Mesh();
        GetComponentInChildren<MeshFilter>().mesh = fog;

        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = (360f / accuracy);
        float angleInRadians = angle * Mathf.Deg2Rad;

        Vector3[] vertices = new Vector3[accuracy + 1];
        Vector2[] uv = new Vector2[vertices.Length];
        int[] triangles = new int[accuracy * 3];

        vertices[0] = transform.position;
        int vertexIndex = 1;
        int triangleIndex = 0;
        for (int i = 0; i < accuracy; i++)
        {
            Vector2 rayDirection = new Vector2(Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians));
            RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, 30f, mask);
            Instantiate(hitDebug, hit.point == Vector2.zero ? 30 * rayDirection.normalized : hit.point, Quaternion.identity);

            vertices[vertexIndex] = hit.point == Vector2.zero ? 30 * rayDirection.normalized : hit.point;

            triangles[triangleIndex] = 0;
            triangles[triangleIndex + 1] = vertexIndex - 1;
            triangles[triangleIndex + 2] = vertexIndex;

            triangleIndex += 3;
            vertexIndex++;
            angleInRadians += angle * Mathf.Deg2Rad;
        }

        fog.vertices = vertices;
        fog.uv = uv;
        fog.triangles = triangles;
    }
}
