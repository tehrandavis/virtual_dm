using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orient : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject Dominant_Hand;
     public GameObject Environment;
     private Vector3 HandPosition;
     private Vector3 EnvironmentPosition;

    void Start()
    {
        HandPosition = Dominant_Hand.transform.position;
        EnvironmentPosition = Environment.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Environment.transform.position = new Vector3(HandPosition.x, EnvironmentPosition.y, HandPosition.z);
        }
    }
}
