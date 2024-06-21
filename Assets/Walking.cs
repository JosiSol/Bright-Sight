using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Walking : MonoBehaviour
{
    public Rigidbody2D rb;
    void OnColliderStay (Collider other)
    {
        rb.velocity = Vector3.zero;
    }

    void Update()
    {
        move();       
    }

    void move()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {rb.velocity = Vector3.up * 1000  * Time.deltaTime;}
        else if(Input.GetKey(KeyCode.DownArrow))
        {rb.velocity = Vector3.down * 1000  * Time.deltaTime;}
        else if(Input.GetKey(KeyCode.LeftArrow))
        {rb.velocity = Vector3.left * 1000  * Time.deltaTime;}
        else if(Input.GetKey(KeyCode.RightArrow))
        {rb.velocity = Vector3.right * 1000 * Time.deltaTime;}
        else
        {rb.velocity = Vector3.zero;}
    }
}
