using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGB283Transform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Translate(Vector3 translation, Space relativeTo = Space.Self)
    {
        if (relativeTo == Space.Self)
        {
            transform.localPosition += translation;
        }
        else
        {
            transform.position += translation;
        }
        
    }

    public void Translate(float x, float y, float z = 0, Space relativeTo = Space.Self)
    {
        if (relativeTo == Space.Self)
        {
            transform.localPosition += new Vector3(x, y, z);
        }
        else
        {
            transform.position += new Vector3(x, y, z);
        }
    }



    public void Rotate(Vector3 axis, float angle)
    {
        transform.eulerAngles += axis * angle;
    }

    public void Rotate(float x, float y, float z)
    {
        transform.eulerAngles += new Vector3(x, y, z);
    }

    public void Scale(float amount)
    {
        transform.localScale += new Vector3(amount, amount, amount);
    }

    public void Scale(float x, float y, float z)
    {
        transform.localScale += new Vector3(x, y, z);
    }

    public void Scale(Vector3 amount)
    {
        transform.localScale += amount;
    }
}
