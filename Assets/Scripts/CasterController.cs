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
    private PlayerMagicManager magic;
    //public float maxMagicUsage;
    //public float currMagicUsage;
	void Start () {
        //currMagicUsage = 0;
        magic = FindObjectOfType<PlayerMagicManager>();
	}
	
	void Update () {
		if(isFiring)
        {
            
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0 /*&& currMagicUsage<maxMagicUsage*/)
            {
                magic.UseMagic(spell.magicUsage, spell.magicUsageDrainMultiplier);
                shotCounter = timeBetweenShots;
                SpellController newSpell = Instantiate(spell, firePoint.position, firePoint.rotation) as SpellController;
                newSpell.speed = spellSpeed;
                
            }
        }
        else
        {
            shotCounter = 0;
            magic.NotUseMagic(spell.magicUsageDrainMultiplier);
        }
        
	}
}
