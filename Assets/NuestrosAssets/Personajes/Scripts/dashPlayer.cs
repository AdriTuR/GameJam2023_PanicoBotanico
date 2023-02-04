using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dashPlayer : MonoBehaviour
{
    //dash ability for the player with space key
    
    
    public float dashSpeed = 10.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
    }

    private void Dash()
    {
        Vector3 dashDirection = transform.forward;
        rb.AddForce(dashDirection * dashSpeed, ForceMode.Impulse);
    }
}
    

