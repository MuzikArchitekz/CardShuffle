using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public int DestroyAfter; // Po kolika sekundách bude zničen objekt

	
	// Update is called once per frame
	void Update () {

        Destroy(gameObject, DestroyAfter);
		
	}
}
