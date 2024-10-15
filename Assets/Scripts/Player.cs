using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera cam;
    public float speed = 25.0f;
    public Vector3 worldPos;
    private Rigidbody2D rb;
    void Start()
    {
         cam=Camera.main;
        Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        worldPos=cam.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        //transform.position=worldPos;
    }

    private void FixedUpdate()
    {
        var destination = Vector3.MoveTowards(transform.position,worldPos,speed*Time.fixedDeltaTime); 
        rb.MovePosition(destination);
    }
}
