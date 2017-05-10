using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFatigueManager : MonoBehaviour {

    public double fatigue;
    public Text FatigueText;
	// Use this for initialization
	void Start () {
        fatigue = 0;
        FatigueText.text = "Fatigue" + fatigue.ToString("F0");

	}
	
	// Update is called once per frame
	void Update () {
        if(fatigue>0)
        fatigue -= Time.deltaTime;
        FatigueText.text = "Fatigue" + fatigue.ToString("F0");
    }

    public void FatigueGain(double amount)
    {
        fatigue += amount;
    }
}
