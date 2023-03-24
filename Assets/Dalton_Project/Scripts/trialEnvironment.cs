using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// add the UXF namespace
using UXF;

public class trialEnvironment : MonoBehaviour
{

    public GameObject leftTarget;
    public GameObject rightTarget;
   // public GameObject heldObject;
    public GameObject goal;
    public GameObject targets;
    public bool targetsStatus;
    public float leftTarget_size;
    public float rightTarget_size;
    public GameObject heldObject;
    public float heldObject_size;

    //public int numMainTrials;
    public float block_number;

    public bool trialActive;
    public float expTrial;

    public Session session;
      
    
    public void PresentStimulus(Trial trial)
        {
            
            // we can call this function via the event "On Trial Begin", which is called when the trial starts
            // here we can imagine presentation of some stimulus

            // get trial number and if experimental trial
            expTrial = trial.settings.GetFloat("experimental_trial");

            // get the left and right target sizes from the INI file
            leftTarget_size = trial.settings.GetFloat("left_target_size");
            rightTarget_size = trial.settings.GetFloat("right_target_size");

            // get handheld object size
            heldObject_size = trial.settings.GetFloat("object_size") - .1f;


            // transform targets
            leftTarget.transform.localScale = leftTarget_size * new Vector3(1f, 1f, 1f);
            rightTarget.transform.localScale = rightTarget_size * new Vector3(1f, 1f, 1f);
            targets.transform.localScale = expTrial * new Vector3(1f, 1f, 1f);
            
            // transform object
            heldObject.transform.localScale = heldObject_size * new Vector3(1f, 1f, 1f);

            // print trial information to console
            Debug.LogFormat("trialEnvironment: Running trial {0}", trial.number);
            Debug.LogFormat("trialEnvironment: Experimental trial is set to {0}", expTrial);
            Debug.LogFormat("trialEnvironment: The 'left target size' for this trial is: {0}", leftTarget_size);
            Debug.LogFormat("trialEnvironment: The 'right target size' for this trial is: {0}", rightTarget_size);
            Debug.LogFormat("trialEnvironment: The 'object size' for this trial is: {0}", heldObject_size);

            //ReactivateTargets();

        }


    void StartTrial()
    {
            // transform targets
            leftTarget.transform.localScale = leftTarget_size * new Vector3(1f, 1f, 1f);
            rightTarget.transform.localScale = rightTarget_size * new Vector3(1f, 1f, 1f);
            targets.transform.localScale = expTrial * new Vector3(1f, 1f, 1f);
            
            // transform object
            heldObject.transform.localScale = heldObject_size * new Vector3(1f, 1f, 1f);

        if (trialActive == false) {
            // start new trial in UXF
            session.BeginNextTrial();
            trialActive = true;
        }
    }

    public void ReactivateTargets()
    {
        heldObject = GameObject.FindGameObjectWithTag("ThrowableCube");
        goal.SetActive(true);
        targets.SetActive(true);
        
        //if (expTrial==0){
        //    targets.SetActive(false);
        //}
    }


   public void StopTrial()
    {
        Debug.Log("STOP");
        session.EndCurrentTrial();
        trialActive = false;
    }


}
