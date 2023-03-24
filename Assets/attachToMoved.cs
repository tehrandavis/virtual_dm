using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class attachToMoved : MonoBehaviour
{
    public GameObject tracked_Object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("ThrowableCube") !=null)
        {
            Debug.Log("movedObject exists");

            tracked_Object = GameObject.FindWithTag("ThrowableCube");

            transform.position = tracked_Object.transform.position;
            
        } else
        {
            Debug.Log("movedObject doesn't exist");
        }
        

    }
}
