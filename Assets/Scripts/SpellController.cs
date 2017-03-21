using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour {

    public float speed;
    public int damageToGive;
    public Collider2D coll;
	void Start () {
        coll = GetComponent<Collider2D>();
        //coll.isTrigger = true;
	}
	
	
	void Update () {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
       
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Destroy(gameObject);
        }
    }
}
