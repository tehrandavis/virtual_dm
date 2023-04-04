using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableMover : MonoBehaviour
{
    [SerializeField] GameObject resetPosition;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void move_forward()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void move_backward()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F10))
        {
            move_forward();
        }

        if (Input.GetKey(KeyCode.F11))
        {
            move_backward();
        }
    }
}
