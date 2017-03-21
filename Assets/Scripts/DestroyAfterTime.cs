using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

    public float time;
	void Start () {
		
	}
	private IEnumerator kill()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
        StartCoroutine(kill());
	}
}
