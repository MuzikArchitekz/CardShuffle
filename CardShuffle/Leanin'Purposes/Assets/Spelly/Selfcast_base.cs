using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfcast_base : MonoBehaviour {


    public GameObject auraprefab;
    public GameObject player;
    public int heal_rate;
    public float cooldown;



	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()




    {
        if (Input.GetKeyDown(KeyCode.X) && cooldown < 1)
        {

            Vector3 locpos = transform.position;
            Quaternion locrot = transform.rotation;

            StatsSystem.healthNow = StatsSystem.healthNow + heal_rate + StatsSystem.spellDmg;


            Instantiate(auraprefab, locpos, locrot);
            cooldown = 10;
        }

        if (Input.GetKey(KeyCode.X) && cooldown >= 1)

        {

            Debug.Log("Spell is on cooldown");

        }

        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            return;
        }

        if (cooldown < 0 )

        {

            cooldown = 0;

        }

        else
        { return; }


    }
}
