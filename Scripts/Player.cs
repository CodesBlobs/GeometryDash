using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 vector;
    public bool grounded;
    Rigidbody2D rb2D;
    public Vector2 autoMoveVector;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb2D.velocity += vector;
        }
        
    }
}
