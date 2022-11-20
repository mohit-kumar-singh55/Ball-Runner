using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour { 
    public Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX = 4.45f;
    public float minX = -4.45f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        // restricting player to go beyond the track in through keys
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;

        // right/left
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        // moving player forwards
       rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}
