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

        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space))
        {
            DashZ();
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Space))
        {
            DashZ();
        }
    }

    private void Dash()
    {
        Vector3 dashDirection = transform.forward * dashSpeed;
        rb.AddForce(dashDirection, ForceMode.Impulse);
    }
    private void DashZ()
    {
        Vector3 dashDirection = transform.right * dashSpeed;
        rb.AddForce(dashDirection, ForceMode.Impulse);
    }
}
    

