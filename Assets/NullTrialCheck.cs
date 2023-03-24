using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// add the UXF namespace
using UXF;

public class NullTrialCheck : MonoBehaviour
{

    public GameObject leftTarget;
    public GameObject rightTarget;
   // public GameObject heldObject;
    public GameObject goal;
    public GameObject targets;
    public GameObject heldObject;
    public float leftTarget_size;
    public float rightTarget_size;
    public float heldObject_size;
    public float block_number;

    public int experimentalTrial;



    //public int numMainTrials;
    public bool trialActive;

    public Session session;
      
    
    public void PresentStimulus(Trial trial)
        {
            // we can call this function via the event "On Trial Begin", which is called when the trial starts
            // here we can imagine presentation of some stimulus
            //heldObject = GameObject.FindGameObjectWithTag("ThrowableCube");
            //block_number = trial.settings.int("block_num");
            Debug.LogFormat("Running trial {0}", trial.number);
            //Debug.LogFormat("Running block is", block_number);

            // we can access our settings to (e.g.) modify our scene
            // for more information about retrieving settings see the documentation
            leftTarget_size = trial.settings.GetFloat("left_target_size");
            rightTarget_size = trial.settings.GetFloat("right_target_size");
            heldObject_size = trial.settings.GetFloat("object_size");
            experimentalTrial = trial.settings.GetInt("exp_trial");
            
            // and set the engine's thrust.
            //spaceShuttleEngine.thrust = trial.settings.GetFloat("thrust");
            Debug.LogFormat("ExperimentManager: The 'left target size' for this trial is: {0}", leftTarget_size);
            Debug.LogFormat("ExperimentManager: The 'right target size' for this trial is: {0}", rightTarget_size);
            Debug.LogFormat("ExperimentManager: The 'object size' for this trial is: {0}", heldObject_size);
            Debug.LogFormat("ExperimentManager: The 'experimentalTrial' for this trial is: {0}", experimentalTrial);


            //LeftTarget.transform.localScale = LeftTargetScale;
            leftTarget.transform.localScale = leftTarget_size * new Vector3(1f, 1f, 1f);
            rightTarget.transform.localScale = rightTarget_size * new Vector3(1f, 1f, 1f);
            heldObject.transform.localScale = heldObject_size * new Vector3(1f, 1f, 1f);

            // end trial and prepare next trial in 5 seconds
            //Invoke("EndAndPrepare", 5);
        }

    void StartTrial()
    {
        // if (trialActive == false){
        //     trialActive = true;
            session.BeginNextTrial();
        //}
        
    }

    public void ReactivateTargets()
    {
        targets.SetActive(true);
        goal.SetActive(true);
    }

   public void StopTrial()
    {
        Debug.Log("STOP");
        session.EndCurrentTrial();
        trialActive = false;
    }

    void Update()
    {
        heldObject = GameObject.FindGameObjectWithTag("ThrowableCube");
    }

}
