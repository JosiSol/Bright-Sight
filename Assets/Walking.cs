using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Walking : MonoBehaviour
{
    public Transform pos;
    private float timeout = 0f;
    private float reset = 0.2f;

    void Update()
    {
        if(timeout > 0)
        {
            timeout -= Time.deltaTime;
        }
        else
        {
            move();
            timeout = reset;
        }
    }

    void move()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {pos.position = new Vector3(pos.position.x,pos.position.y + 1,pos.position.z);}
        else if(Input.GetKey(KeyCode.DownArrow))
        {pos.position = new Vector3(pos.position.x,pos.position.y - 1,pos.position.z);}
        else if(Input.GetKey(KeyCode.LeftArrow))
        {pos.position = new Vector3(pos.position.x - 1,pos.position.y,pos.position.z);}
        else if(Input.GetKey(KeyCode.RightArrow))
        {pos.position = new Vector3(pos.position.x + 1,pos.position.y,pos.position.z);}
    }
}
