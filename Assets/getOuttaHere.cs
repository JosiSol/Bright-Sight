using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class getOuttaHere : MonoBehaviour
{
    public int room;
    
    void OnTriggerEnter2D(Collider2D col){
        SceneManager.LoadScene(room);
    }
}
