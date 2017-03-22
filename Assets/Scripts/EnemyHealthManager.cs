using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int health;
    private int currentHealth;
    private PlayerFatigueManager fatigue;

    // Use this for initialization
    void Start () {
        fatigue = FindObjectOfType<PlayerFatigueManager>();
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <=0)
        {
            Destroy(gameObject);
        }
	}

    public void HurtEnemy (int damage)
    {
        int newDamage = damage - damage * ((int)fatigue.fatigue / 100);
        if (newDamage > 0)
            currentHealth -= newDamage; 
    }
}
