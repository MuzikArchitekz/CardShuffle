using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclickenable : MonoBehaviour {


    public GameObject Hudik;


	

	void Update () {

        if (Input.GetKey(KeyCode.Y))
        {

            Hudik.SetActive(true);

        }
		
	}
}
