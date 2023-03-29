using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMesh
{
    public Mesh Generate()
    {
        Mesh mesh = new Mesh();
        mesh.name = "CustomMesh";

        Vector3[] vertices = new Vector3[4]
        {
            new Vector3(0,0,0),
            new Vector3(1,0,0),
            new Vector3(1,1,0),
            new Vector3(0,1,0),
        };
        mesh.vertices = vertices;

        int[] triangles = new int[6]
        {
            0,2,1,
            //0,3,2,
            0,1,2
        };
        mesh.triangles = triangles;


        return mesh;
    }
}
