using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMagicManager : MonoBehaviour {

    public double maxMagicUsage;
    public double currMagicUsage;
    public Text MagicText;
    private PlayerFatigueManager fatigue;
    public double magicIncrease;
    private double  counter = 0;
	// Use this for initialization
	void Start () {
        fatigue = FindObjectOfType<PlayerFatigueManager>();
        currMagicUsage = 0;
        
        MagicText.text = "Magic Usage: " + currMagicUsage.ToString("F0");
        
	}
	
	// Update is called once per frame
	void Update () {
        MagicText.text = "Magic Usage: " + currMagicUsage.ToString("F0");
        if (currMagicUsage > maxMagicUsage)
        {
            counter += magicIncrease;
            maxMagicUsage += counter;
        }

    }

    public void UseMagic(float usage, float drainMult)
    {
        //float counter = currMagicUsage;
        currMagicUsage += usage;
        if (currMagicUsage > maxMagicUsage)
        {
            fatigue.FatigueGain((currMagicUsage - maxMagicUsage) / 20);
        }
        /*while(currMagicUsage>=counter)
            currMagicUsage -= Time.deltaTime * drainMult;*/

    }

    public void NotUseMagic(float drainMult)
    {
        if (currMagicUsage > 0)
            currMagicUsage -= Time.deltaTime * drainMult;
    }
}
