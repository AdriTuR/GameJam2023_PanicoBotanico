using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionItemQ : MonoBehaviour
{
    public GameObject itemQ;
    public GameObject seleccionItem;

    public string[] listaItems = new string[] { "itemPala", "itemRegadera", "itemAbono"};
    public int itemAparecer;
    private int itemE;
    private bool hasRun = false;
    // Start is called before the first frame update
    private void Awake()
    {
        itemAparecer = Random.Range(0, 2);
        itemQ = GameObject.Find(listaItems[itemAparecer]);

    }
    void Start()
    {       
        seleccionItem = GameObject.Find("seleccionItemQ");
        itemQ.transform.position = seleccionItem.transform.position;
        itemQ.SetActive(false);

        seleccionItem.SetActive(false);

    }

    private void OnEnable()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled /*&& hasRun==false*/)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("¡¡¡¡¡Activado objeto Q!!!!!!");

                itemQ.SetActive(true);
                GameObject itemE = GameObject.Find("seleccionItemE").GetComponent<seleccionItemE>().itemE;
                itemE.SetActive(false);
                hasRun = true;

            }
        }
    }
}
