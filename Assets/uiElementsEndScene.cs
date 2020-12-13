using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiElementsEndScene : MonoBehaviour
{
    public Text hiScoreTxt;
    public Text hitsTakenTxt;
    public Text hitsGivenTxt;
    public Text dmgTakenTxt;
    public Text dmgGivenTxt;
    public Text shotsTxt;
    public Text accuracyTxt;
    public Text buildingdedTxt;
    public Text enemiesdedTxt;
    
    // Start is called before the first frame update
    void Start()
    {
       
        hitsTakenTxt.text = "Hits Taken" + DataSingleton.hitsTaken.ToString();
        hitsGivenTxt.text = "Hits Given" + DataSingleton.hitsGiven.ToString();
        dmgTakenTxt.text = "Damgage Taken" + DataSingleton.dmgTaken.ToString();
        dmgGivenTxt.text = "Damage Given" + DataSingleton.dmgGiven.ToString();
        shotsTxt.text = "Shots Fired" + DataSingleton.shotsFired.ToString();
        accuracyTxt.text = "Accuracy" + DataSingleton.accuracyPercent.ToString();
        buildingdedTxt.text = "Buildings Destroyed" + DataSingleton.structuresDestroyed.ToString();
        enemiesdedTxt.text = "Enemies Slain" + DataSingleton.enemiesSlain.ToString();

        hiScoreTxt.text = "Hi-Score:" + DataSingleton.hiSCore.ToString();
        PlayerPrefabReferences.PPR.hiScore = DataSingleton.hiSCore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
