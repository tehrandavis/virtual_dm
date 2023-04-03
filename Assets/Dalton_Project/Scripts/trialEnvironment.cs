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
    public GameObject startbutton;
    public float start_location;
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
    public int trialNumber;

    public string selection;

    public float obj_to_target_scale = .7f;
      
    
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
            heldObject_size = trial.settings.GetFloat("object_size") - .075f;

            // get start button location
            start_location = trial.settings.GetFloat("start_location");



            // transform targets
            leftTarget.transform.localScale = leftTarget_size * new Vector3(obj_to_target_scale, obj_to_target_scale, obj_to_target_scale);
            rightTarget.transform.localScale = rightTarget_size * new Vector3(obj_to_target_scale, obj_to_target_scale, obj_to_target_scale);

            // makes targets disappear if experimental trial = 0
            targets.transform.localScale = expTrial * new Vector3(1f, 1f, 1f);

            if(expTrial == 0)
            {
                goal.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            } else
            {
                goal.transform.localScale = new Vector3(0f, 0f, 0f);
            }
            
            // transform object
            heldObject.transform.localScale = heldObject_size * new Vector3(1f, 1f, 1f);

            // transform start button location
            startbutton.transform.localPosition = new Vector3(start_location, 0.75f, -0.3f);

            // print trial information to console
            Debug.LogFormat("trialEnvironment: Running trial {0}", trial.number);
            Debug.LogFormat("trialEnvironment: Experimental trial is set to {0}", expTrial);
            Debug.LogFormat("trialEnvironment: The 'left target size' for this trial is: {0}", leftTarget_size);
            Debug.LogFormat("trialEnvironment: The 'right target size' for this trial is: {0}", rightTarget_size);
            Debug.LogFormat("trialEnvironment: The 'object size' for this trial is: {0}", heldObject_size);
            Debug.LogFormat("trialEnvironment: The 'start location' for this trial is: {0}", start_location);
            //ReactivateTargets();

        }


    void StartTrial()
    {

            // transform targets
            //leftTarget.transform.localScale = leftTarget_size * new Vector3(1f, 1f, 1f);
            //rightTarget.transform.localScale = rightTarget_size * new Vector3(1f, 1f, 1f);
            //targets.transform.localScale = expTrial * new Vector3(1f, 1f, 1f);
            
            // transform object
            heldObject.transform.localScale = heldObject_size * new Vector3(1f, 1f, 1f);

            // transform start button
           // startbutton.transform.localPosition = new Vector3(start_location, 1.7f, -0.25f);

        if (trialActive == false) {
            // start new trial in UXF
            session.BeginNextTrial();
            trialActive = true;
        }
    }

    public void ReactivateTargets()
    {
        heldObject = GameObject.FindGameObjectWithTag("ThrowableBall");
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
