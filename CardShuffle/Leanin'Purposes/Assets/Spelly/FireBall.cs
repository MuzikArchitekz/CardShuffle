using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {

    public Rigidbody projectile;
    public float speed = 20;
    public Canvas cross;
    public float cooldown;
    static public int damage;
    // public float stunTime;
   // static public bool DoStun;



    private void Update()
    {



        if (Input.GetKeyDown(KeyCode.V) && cooldown < 1)
        {

            Rigidbody instantiatedprojectile = Instantiate(projectile, transform.position + (transform.forward * 2), transform.rotation) as Rigidbody;
            instantiatedprojectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            cooldown = 10;
        }

        if (Input.GetKey(KeyCode.V) && cooldown > 0)

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

        if (cooldown < 0)

        {

            cooldown = 0;

        }

        else
        { return; }
    }   


    


}
