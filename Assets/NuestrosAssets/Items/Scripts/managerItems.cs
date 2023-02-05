using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerItems : MonoBehaviour
{
    //public string[] listaItems = new string[] { "itemPala", "itemRegadera", "itemAbono" };
    GameObject[] todosItems;
    private void Awake()
    {
        todosItems = GameObject.FindGameObjectsWithTag("Items");

        /*
        for (int i = 0; i < listaItems.Length; i++)
        {
            GameObject item = GameObject.Find(listaItems[i]);
            item.SetActive(false);
        }*/
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in todosItems)
        {
            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
