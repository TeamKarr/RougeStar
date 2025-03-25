using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {

        // rotate ship
        Vector2 m = Camera.main.ScreenToWorldPoint( Input.mousePosition);
        transform.Rotate(new Vector3(0,0,1), 1);
        Vector2 direction = (m - (Vector2) transform.position ).normalized;
        transform.up = direction;

        // move ship
        float forward = Input.GetAxis("vertical");

        rb.AddForce(transform.up * 100f * forward, ForceMode2D.Force);



    }
}
