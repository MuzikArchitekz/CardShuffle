using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

    // Proměnné


    Animator anim;
    public float rychlost;
    public float rychlostSkoku;
    public float gravitace;
    private Vector3 moveDirection = Vector3.zero;
    public GameObject Hudik;

    private void Start()
    {

        anim = GetComponent<Animator>();

    }


    void Update ()

    {

    



        CharacterController controller = GetComponent<CharacterController>();
        
        // Je Hráč/Controller na zemi ?

        if (controller.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            Vector3 newRotation = transform.eulerAngles;
            newRotation.y = Camera.main.transform.eulerAngles.y;
            transform.eulerAngles = newRotation;





            //Vynásob rychlostí 

            moveDirection *= rychlost;

            //Skákání

            if (Input.GetButton("Jump"))

                moveDirection.y = rychlostSkoku;
           //     anim.SetBool("IsJumping", true)

            

          //  else
            

            //    anim.SetBool("IsJumping", false);

           


        }

        // aplikuj gravitaci na kontroler

        moveDirection.y -= gravitace * Time.deltaTime;

        //Donut character pohybovat

        controller.Move(moveDirection * Time.deltaTime);

        //Animování chůze

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {

            anim.SetBool("IsWalking", true);

        }

        else { anim.SetBool("IsWalking", false); }

        if (Input.GetKey(KeyCode.A))

        {

            anim.SetBool("IsLeftStrafing", true);

        }
        else
        {

            anim.SetBool("IsLeftStrafing", false);

        }

        if (Input.GetKey(KeyCode.D))

        {

            anim.SetBool("IsRightStrafing", true);

        }
        else
        {

            anim.SetBool("IsRightStrafing", false);

        }













    }
}
