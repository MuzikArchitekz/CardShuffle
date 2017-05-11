using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoActions : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            StatsSystem.healthNow -= FireBall.damage;

        }

    }
}
