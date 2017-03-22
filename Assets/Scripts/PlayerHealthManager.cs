using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {
    public int startingHealth;
    public int currentHealth;
    public Text HealthText;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
        HealthText.text = "Health: " + currentHealth.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if(currentHealth<=0)
        {
            gameObject.SetActive(false);
        }
        HealthText.text = "Health: " +  currentHealth.ToString();
	}

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
    }
}
