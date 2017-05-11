using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baiting : MonoBehaviour {


    public float rotateSpeed = 5f;

    void Update()
    {


        if (Input.GetKey(KeyCode.B))
        {
            transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
        }
        else
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        };

    }
}

