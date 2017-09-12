using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public Camera mainCamera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }

    public void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSpeed(1);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            ChangeSpeed(-1);
        }
    }

    public void ChangeSpeed(int Direction)
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            graphicalObject obj = hit.transform.GetComponent<graphicalObject>();
            obj.moveSpeed += 2 * Direction;
            obj.spinSpeed += 2 * Direction;

            if (obj.moveSpeed < 0)
            {
                obj.moveSpeed = 0;
            }
            if (obj.spinSpeed < 0)
            {
                obj.spinSpeed = 0;
            }
        }
    }
}
