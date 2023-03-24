using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class StartTrialController : MonoBehaviour
{
    public Session session;
    public bool trialActive;

    void StartTrial()
    {
        if (trialActive == false){

            trialActive = true;
            session.BeginNextTrial();
        }
        
    }
}
