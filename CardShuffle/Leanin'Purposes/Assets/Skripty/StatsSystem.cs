using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsSystem : MonoBehaviour {

    // Komentáře k proměnným
    // Na ten MonoBehaviour si ale moc nezvykej protože na multiplayer
    // Budeme používat NetworkBehaviour
    // Určení promenných na ukladání defaultních hodnot statů
    // můžeš si vlastně navolit uplně jakékoliv proměnné když budeš vědět jak je aplikovat:D
    // public float moveSpeed;  dodělám později až budu mít kompletní skript na MS
    // public float jumpSpeed;  dodělám později až budu mít kompletní skript na MS
    // public string playerName --- dodělám pozděj až budu mít hotový skript na multiplayering nebo HUD;



    static public int healthMax;
    static public int healthNow;
    static public int manaMax;
    static public int manaNow;
    static public int basicDmg;
    static public int spellDmg;

    public Text HUD; // musíš přidat referenci k objektu v editoru
    public string br = "\n";




    // public , static , priv void komentáře

    //Public means that anything anywhere has direct access to whatever it is.
    // public = cokoliv a kdokoliv má přímý přístup k void proměnné nebo čemukoliv co obsahuje void/var
    // static = https://unity3d.com/learn/tutorials/topics/scripting/statics -- najdeš tady , sám je moc nechápu s varama:D
    // private = znamenají jenom "členové" tohoto classu nebo "childs" což je to , že něco dáš do objektu , např , partikly..
    // protected = znamenají jenom tahle třída , její "přítelé"(kterí v c# nejsou jen v c++) a její "děti" mají přístup..:D


    void Start()
       
    {

        healthMax = 10000;
        healthNow = healthMax;
        

        manaMax = 10000;
        manaNow = manaMax;

        #region komentáře k poškození a síle schopností
        // tahle hodnota bude ubirat zivoty kdyz nekoho "bouchnes" resp. tvůj mesh bude
        // kolidovat" s jeho kdyz akci zacnes ty:D
        // tato hodnota( spell dmg) bude ubirat / pridavat "spelldmg" resp. Když použiješ healing auru
        // ktera bude mít efekt "Cast a aura to heal its caster for 100 + spelldmg
        // to bude jakoby náš "vzorec" na healing atp atp :D
        #endregion

        basicDmg = 10;
        spellDmg = 10;

    }


    // void update komenty
    // Tady se bude updatovat kazda hodnota aby se zobrazovala na HUDu.
    // Takže si vytvoř třeba text v UI menu
    // Nastav si rect transform u textu na : 
    // posX = -500 , posY = 250 , posZ = 0
    // wid = 150 , height = 80 ;
    // to by ti mělo hodit text tak aby byl někde vpravo v rohu
    // s anchorama se asi nemusíš trápit zatím do bodu kdy nebudeš
    // používat corsshair nebo cokoliv co potřebuje přesné "zakotvení"



    //  tady budeme updatovat hodnoty proměnných co se budou aktualizovat na HUDu
    //  můžeš použít i void Lateupdate ale to se aplikouje až po framu a ne na začátku
    //  hlavně když pracujes s UI musíš nahoře napsat "using Unityengine.UI;"



    void Update()
    {

        HUD.text = "HP : " + healthNow + br + "MANA : " + manaNow + br + "basicDMG " + basicDmg + br + "spellDMG :" + spellDmg;



        
    }






}




