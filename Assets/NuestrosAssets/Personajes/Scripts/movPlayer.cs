using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlayer : MonoBehaviour
{

    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Transform camTransform = Camera.main.transform;
        Vector3 camPosition = new Vector3(camTransform.position.x, transform.position.y, camTransform.position.z);
        Vector3 direction = (transform.position - camPosition).normalized;
        Vector3 forwardMovement = direction * Input.GetAxis("Vertical");
        Vector3 horizontalMovement = camTransform.right * Input.GetAxis("Horizontal");
        Vector3 movement = Vector3.ClampMagnitude(forwardMovement + horizontalMovement, 1);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        //que el personaje mire en la direccion en la que se mueve
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

    }


}