using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

    // proměnné

    public float turnSpeed = 4f;
    public float panSpeed = 4f;
    public float zoomSpeed = 4f;

    




    private Vector3 mouseOrigin;
    private bool isPanning;
    private bool isRotating;
    private bool isZooming;






    void Update ()

    {

        if (Input.GetMouseButtonDown(0))
        {

            mouseOrigin = Input.mousePosition;
            isRotating = true;

        }

        if (Input.GetMouseButton(1))

        {

            mouseOrigin = Input.mousePosition;
            isPanning = true;

        }

        if (Input.GetMouseButtonDown(2))

        {

            mouseOrigin = Input.mousePosition;
            isZooming = true;

        }

        if (!Input.GetMouseButton(0)) isRotating = false;
        if (!Input.GetMouseButton(1)) isPanning = false;
        if (!Input.GetMouseButton(2)) isZooming = false;

        if (isRotating)
        {

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);


        }

        if (isZooming)

        {

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            Vector3 move = pos.y * zoomSpeed * transform.forward;
            transform.Translate(move, Space.World);

        }

        if (isPanning)

        {

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            Vector3 move = pos.y * zoomSpeed * transform.forward;
            transform.Translate(move, Space.World);

        }


		
	}
}
