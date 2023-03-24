﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class ObjectCollision: MonoBehaviour
{
    public Session session;
    public bool TargetSpaceDestroyed = false;
    public bool NextTrial = false;
    public bool trialActive;

    private GameObject targets;
    private GameObject goal;
    public trialEnvironment other;

    public GameObject experimentManager;

    private void Start()
    {
        targets = GameObject.Find("Targets");
        goal = GameObject.Find("Goal");
        experimentManager = GameObject.Find("ExperimentManager");
        other = experimentManager.GetComponent<trialEnvironment>();
    }

    //Destroy everything that enters the trigger
    void OnCollisionEnter(Collision coll)
    {     
        if (coll.gameObject.tag == "TargetSpace")
        {
            targets.transform.localScale = new Vector3(0f, 0f, 0f);
            targets.SetActive(false);
            TargetSpaceDestroyed = true;
        }
        else if (coll.gameObject.tag == "TargetBorder")
        {
            Destroy(gameObject);
        }
        else if (coll.gameObject.tag == "Goal" && TargetSpaceDestroyed )
        {
            //next trial
            //Destroy(gameObject);
            //NextTrial = true;
            goal.SetActive(false);
            //Debug.Log("STOP");
            //other.StopTrial();
            //session.EndCurrentTrial();
            Debug.Log("end trial ran!!!!!");
            Destroy(gameObject);
            trialActive = false;
            other.StopTrial();

        }
        else if (coll.gameObject.tag == "Goal" && other.expTrial==0 )
        {
            //next trial
            //Destroy(gameObject);
            //NextTrial = true;
            goal.SetActive(false);
            //Debug.Log("STOP");
            //other.StopTrial();
            //session.EndCurrentTrial();
            Debug.Log("end trial ran!!!!!");
            Destroy(gameObject);
            trialActive = false;
            other.StopTrial();

        }
    }

}