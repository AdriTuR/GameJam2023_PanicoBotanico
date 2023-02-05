using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class salirMenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update


    private void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.F4))
        {
           

            SceneManager.LoadScene(0);
        }
    }
    public void salirMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
