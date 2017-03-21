using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasterController : MonoBehaviour {

    public bool isFiring;
    public SpellController spell;
    public float spellSpeed;
    public float timeBetweenShots;
    private float shotCounter;
    public Transform firePoint;
	
	void Start () {
		
	}
	
	void Update () {
		if(isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter<=0)
            {
                shotCounter = timeBetweenShots;
                SpellController newSpell = Instantiate(spell, firePoint.position, firePoint.rotation) as SpellController;
                newSpell.speed = spellSpeed;
                
            }
        }
        else
        {
            shotCounter = 0;
        }
        
	}
}
