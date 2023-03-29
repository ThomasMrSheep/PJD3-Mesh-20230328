using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Mesh mesh;

    public Material Material;

    private void Awake()
    {
        CustomMesh customMesh = new CustomMesh();

        mesh = customMesh.Generate();

        GameObject go = new GameObject("Mesh",typeof(MeshFilter),typeof(MeshRenderer));
        MeshFilter filter = go.GetComponent<MeshFilter>();

        filter.mesh = mesh;

        MeshRenderer renderer = go.GetComponent<MeshRenderer>();
        renderer.sharedMaterial = Material;
    }
}
