using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphicalObject : MonoBehaviour {

    private Vector3 startPosition;
    public Material material;
    public IGB283Transform t;
    private float direction = 1;
    public float spinSpeed = 10;
    public float moveSpeed = 5;
    public bool buddy = false;
    public Camera mainCamera;
    private Mesh mesh;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        // Add a MeshFilter and MeshRenderer to the Empty GameObject
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        // Get the Mesh from the MeshFilter
        mesh = GetComponent<MeshFilter>().mesh;
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
            new Vector3(0, 5),
            new Vector3(0.5f, 6),
            new Vector3(1, 5),
            new Vector3(1, 5),
            new Vector3(1.5f, 6),
            new Vector3(2, 5),
            new Vector3(2, 5),
            new Vector3(2.5f, 6),
            new Vector3(3, 5),
            new Vector3(3, 5),
            new Vector3(3.5f, 6),
            new Vector3(4, 5),
            new Vector3(4, 5),
            new Vector3(4.5f, 6),
            new Vector3(5, 5),
            new Vector3(5, 5),
            new Vector3(6, 4.5f),
            new Vector3(5, 4),
            new Vector3(5, 4),
            new Vector3(6, 3.5f),
            new Vector3(5, 3),
            new Vector3(5, 3),
            new Vector3(6, 2.5f),
            new Vector3(5, 2),
            new Vector3(5, 2),
            new Vector3(6, 1.5f),
            new Vector3(5, 1),
            new Vector3(5, 1),
            new Vector3(6, 0.5f),
            new Vector3(5, 0),
            new Vector3(5, 0),
            new Vector3(4.5f, -1),
            new Vector3(4, 0),
            new Vector3(4, 0),
            new Vector3(3.5f, -1),
            new Vector3(3, 0),
            new Vector3(3, 0),
            new Vector3(2.5f, -1),
            new Vector3(2, 0),
            new Vector3(2, 0),
            new Vector3(1.5f, -1),
            new Vector3(1, 0),
            new Vector3(1, 0),
            new Vector3(0.5f, -1),
            new Vector3(0, 0),
            new Vector3(0, 0),
            new Vector3(-1, 0.5f),
            new Vector3(0, 1),
            new Vector3(0, 1),
            new Vector3(-1, 1.5f),
            new Vector3(0, 2),
            new Vector3(0, 2),
            new Vector3(-1, 2.5f),
            new Vector3(0, 3),
            new Vector3(0, 3),
            new Vector3(-1, 3.5f),
            new Vector3(0, 4),
            new Vector3(0, 4),
            new Vector3(-1, 4.5f),
            new Vector3(0, 5),
            new Vector3(2, 1),
            new Vector3(2.5f, 1.5f),
            new Vector3(3, 1),
            new Vector3(2, 4),
            new Vector3(2.5f, 3.5f),
            new Vector3(3, 4),

        };
        Vector3[] newVertices = new Vector3[mesh.vertices.Length];
        for (int i = 0; i < mesh.vertices.Length; i++)
        {
            newVertices[i] = new Vector3(mesh.vertices[i].x - 2.5f, mesh.vertices[i].y - 2.5f);
        }

        mesh.vertices = newVertices;

        // Set vertex indicies
        int[] triangles = new int[mesh.vertices.Length];
        
        for (int i = 0; i < triangles.Length; i++)
        {
            triangles[i] = i;
        }
        mesh.triangles = triangles;

        transform.Translate(new Vector3(1, 0));
    }

    private void Update()
    {
        //SideToSide();
        //newBuddy();
        //changeColour();
        experiemt();
    }

    void experiemt()
    {
        
    }

    public void newBuddy()
    {
        if (!buddy)
        {
            graphicalObject bud = Instantiate(this, new Vector3(transform.position.x, transform.position.y + 5), transform.rotation);
            bud.spinSpeed = 50;
            bud.moveSpeed = 10;
            bud.buddy = true;
            buddy = true;
        }
    }

    public void SideToSide()
    {
        if (transform.position.x >= 9)
        {
            direction = -1;
        }
        else if (transform.position.x <= -9)
        {
            direction = 1;
        }

        t.Translate(new Vector3(1, 0) * moveSpeed * direction * Time.deltaTime);
        t.Rotate(new Vector3(0, 0, 1), spinSpeed * Time.deltaTime);
    }

    public void changeColour()
    {
        Color[] colours = new Color[mesh.vertices.Length];

        for (int i = 0; i < colours.Length; i++)
        {
            colours[i] = new Color(Vector3.Distance(transform.position, startPosition) / 18, 0.7f , Vector3.Distance(transform.position, startPosition)/18);
        }

        mesh.colors = colours;
    }
}
