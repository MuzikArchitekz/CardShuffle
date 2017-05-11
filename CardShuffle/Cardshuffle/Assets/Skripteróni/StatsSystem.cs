using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class StatsSystem : NetworkBehaviour
{

    public const int maxHealth = 100;
    [SyncVar] public int currentHealth = maxHealth;
    public Text hptext;


    public void TakeDmg(int amount)
    {
        if (!isServer)

        {

            return;

        }

        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("U died!");

        }
        

    }

    void Update()
    {

        hptext.text = "HP " + currentHealth;

        if (Input.GetKeyDown(KeyCode.C))
        {

            TakeDmg(10);

        }

    }


}
