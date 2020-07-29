using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CIrcle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        
        if (Input.GetKey(KeyCode.UpArrow))
            dir += Vector3.up;
        if (Input.GetKey(KeyCode.DownArrow))
            dir += Vector3.down;
        if (Input.GetKey(KeyCode.LeftArrow))
            dir += Vector3.left;
        if (Input.GetKey(KeyCode.RightArrow))
            dir += Vector3.right;
        
        transform.position += dir * Time.deltaTime * 50;
        
    }
}
