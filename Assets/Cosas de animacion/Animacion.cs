using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion : MonoBehaviour
{
    public Animator anim;
    private float inputH;
    private float inputV;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        
        
        
    }
}
