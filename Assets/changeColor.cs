using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public GameObject eMgr;
    public int trial = 0; // set initial value of trial to 0
    public Color object_color = Color.white; // set initial value of object_color to white

    // Start is called before the first frame update
    void Start(){
        eMgr = GameObject.Find("ExperimentManager");
    }
    
    void Update()
    {
        trial = eMgr.GetComponent<trialEnvironment>().sequence_number;

        if (trial == 3)
        {
            object_color = Color.red; // set object_color to red
            Renderer rend = GetComponent<Renderer>(); // get the Renderer component
            rend.material.color = object_color; // set the color of the material to red
        } else {
            object_color = Color.white; // set object_color to white
            Renderer rend = GetComponent<Renderer>(); // get the Renderer component
            rend.material.color = object_color; // set the color of the material to white
        }
    }
}
