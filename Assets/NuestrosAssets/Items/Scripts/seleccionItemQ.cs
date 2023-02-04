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
        seleccionItem.SetActive(false);

    }

    private void OnEnable()
    {
        itemQ.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                
                itemQ.SetActive(true);
            }
        }
    }
}
