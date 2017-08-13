using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphicalObject : MonoBehaviour {

    public Material material;

    // Use this for initialization
    void Start()
    {
        // Add a MeshFilter and MeshRenderer to the Empty GameObject
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        // Get the Mesh from the MeshFilter
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        // Set the material to the material we have selected
        GetComponent<MeshRenderer>().material = material;
        // Clear all vertex and index data from the mesh
        mesh.Clear();
        mesh.vertices = new Vector3[] {
            new Vector3(0, 0),
            new Vector3(5, 0),
            new Vector3(5, 1),
            new Vector3(0, 0),
            new Vector3(0, 1),
            new Vector3(5, 1),
            new Vector3(0, 1),
            new Vector3(1, 1),
            new Vector3(1, 4),
            new Vector3(0, 1),
            new Vector3(1, 4),
            new Vector3(0, 4),
            new Vector3(5, 1),
            new Vector3(5, 4),
            new Vector3(4, 4),
            new Vector3(5, 1),
            new Vector3(4, 4),
            new Vector3(4, 1),
            new Vector3(0, 4),
            new Vector3(5, 4),
            new Vector3(0, 5),
            new Vector3(0, 5),
            new Vector3(5, 5),
            new Vector3(5, 4),
            new Vector3(1, 1),
            new Vector3(1, 4),
            new Vector3(2.5f, 2.5f),
            new Vector3(4, 1),
            new Vector3(4, 4),
            new Vector3(2.5f, 2.5f),

        };
        // Set vertex indicies
        int[] triangles = new int[mesh.vertices.Length];
        
        for (int i = 0; i < triangles.Length; i++)
        {
            triangles[i] = i;
        }
        mesh.triangles = triangles;
    }
}
