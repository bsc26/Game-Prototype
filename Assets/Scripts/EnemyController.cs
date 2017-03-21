using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody2D body;
    public float speed;
    public PlayerController player;
    private Transform form;
    private Camera cam;
    void Start () {
        body = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
        cam = FindObjectOfType<Camera>();
        form = GetComponent<Transform>();
    }
	
	
	void Update () {
        // Distance from camera to object.  We need this to get the proper calculation.
        float camDis = cam.transform.position.y - form.position.y;

        // Get the mouse position in world space. Using camDis for the Z axis.
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(player.transform.position.y - form.position.y, player.transform.position.x - form.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        body.rotation = angle;
    }

    void FixedUpdate()
    {
        body.velocity = (transform.right * speed);
    }
}
