using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Near_TV : MonoBehaviour
{
    public GameObject go;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        go.SetActive(true);
    }

    void  OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        go.SetActive(false);
    }
}
