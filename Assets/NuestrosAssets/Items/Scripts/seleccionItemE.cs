using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionItemE : MonoBehaviour
{
    public GameObject seleccionItem;
    public GameObject itemE;
    public string[] listaItems = new string[] { "itemPala", "itemRegadera", "itemAbono", "itemArmaduraEspinas" };
    public int itemAparecer;
    private int itemQ;
    private bool hasRun = false;
    // Start is called before the first frame update
    private void Awake()
    {
        itemAparecer = Random.Range(0, 4);
        while (itemAparecer == itemQ)
        {
            itemAparecer = Random.Range(0, 4);
        }
        itemE = GameObject.Find(listaItems[itemAparecer]);
        itemQ = GameObject.Find("seleccionItemQ").GetComponent<seleccionItemQ>().itemAparecer;

    }
    void Start()
    {
        
       

        seleccionItem = GameObject.Find("seleccionItemE");
        itemE.transform.position = seleccionItem.transform.position;
        itemE.SetActive(false);
      
       
        seleccionItem.SetActive(false);

    }

    private void OnEnable()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled /*&& hasRun == false*/)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("¡¡¡¡¡Activado objeto E!!!!!!");
                itemE.SetActive(true);
                GameObject itemQ = GameObject.Find("seleccionItemQ").GetComponent<seleccionItemQ>().itemQ;
                itemQ.SetActive(false);
                hasRun = true;
            }
        }
    }
}
