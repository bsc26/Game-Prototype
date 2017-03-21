using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D body;
    public float speed;
    private Vector2 movement;
    private Vector2 velocity;
    private Camera cam;
    private Transform form;
    public CasterController cast;
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        cam = FindObjectOfType<Camera>();
        form = GetComponent<Transform>();
	}

	void Update ()
    {

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        movement = new Vector2(moveHorizontal, moveVertical);
        velocity = movement * speed;
        // Distance from camera to object.  We need this to get the proper calculation.
        float camDis = cam.transform.position.y - form.position.y;

        // Get the mouse position in world space. Using camDis for the Z axis.
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - form.position.y, mouse.x - form.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        body.rotation = angle;

        if (Input.GetMouseButtonDown(0))
            cast.isFiring = true;
        if (Input.GetMouseButtonUp(0))
            cast.isFiring = false;

    }

    void FixedUpdate()
    {
       
        body.velocity = movement*speed;

    }
    /*void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spell")
        {
            other.gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
    }*/
}
