using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class trialController : MonoBehaviour
{
    public Session session;
    public bool trialActive = true;

    void trialToggle()
    {
        if (trialActive == false){
            trialActive = true;
            session.BeginNextTrial();
        }

        if (trialActive == true){
            trialActive = false;
            session.EndCurrentTrial();
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            Debug.Log("spacekey pressed");
            trialToggle();
        }
    }
}