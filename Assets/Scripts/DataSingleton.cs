using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    public static DataSingleton main;

    
    public  static int hitsTaken;
    public static int dmgTaken;
    public static int hitsGiven;    
    public static int dmgGiven;
    public static int shotsFired;
    public static int accuracyPercent ;
    public static int structuresDestroyed; 
    public static int enemiesSlain;
    public static float hiSCore;

    public int hitsTakenTxt;
    public int hitsGivenTxt;
    public int dmgTakenTxt;
    public int dmgGivenTxt;
    public int shots;
    public float accuracyTxt;
    public int buildingded;
    public int enemiesded;
    public float hiScore;
   
    // Start is called before the first frame update
    void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
        if (main == null)
        {
            main = this;
        }
        else
        {
            print("a second enemy singleton existed: Original = " + main.gameObject.name + " - Second: " + gameObject.name);
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hitsGivenTxt = hitsGiven;
        dmgTakenTxt = dmgTaken;
        dmgGivenTxt = dmgGiven;
        hitsTakenTxt = hitsTaken;
        buildingded = structuresDestroyed;
        enemiesded = enemiesSlain;
        shots = shotsFired;
        if((shotsFired > 0) ) {
            accuracyTxt = ((float)hitsGivenTxt / shots) ;
        }
        
        hiScore = Mathf.Round((enemiesSlain * accuracyTxt) *buildingded +hitsGivenTxt-hitsTakenTxt) ;
        hiSCore = hiScore;
    }
}
