using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick1 : MonoBehaviour
{

    public Button sendBTN;
    public Text setHP;
    public Text setMP;
    public Text setbDMG;
    public Text setsDMG;
    static public GameObject UI;

    



    public void Start()
    {

        Button btn = sendBTN;
        btn.onClick.AddListener(TaskOnClick);



    }

    public void TaskOnClick()
    {

        StatsSystem.healthNow = int.Parse(setHP.text);
        StatsSystem.manaNow = int.Parse(setMP.text);
        StatsSystem.basicDmg = int.Parse(setbDMG.text);
        StatsSystem.spellDmg = int.Parse(setsDMG.text);

      

    }
}
	

