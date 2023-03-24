using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class GoalCollider: MonoBehaviour
{
    public Session session;

    public GameObject handHeldObject;

    private void Update()
    {
        handHeldObject = GameObject.FindGameObjectWithTag("ThrowableCube");
        //goal = GameObject.Find("Goal");
       // experimentManager = GameObject.Find("ExperimentManager");
    }

    void OnCollisionEnter(Collision coll)
    {     
        // if the object is a cube destory it.
        // and end the trial
        // else do nothing
        if (coll.gameObject.tag == "ThrowableCube")
        {
            Destroy(coll.gameObject); 
            endTrial();
        }
        else
        {
            Debug.Log("other object hit goal");
        }
    }

    void endTrial(){
        session.EndCurrentTrial();
        Debug.Log("end trial ran!!!!!");
    }

}
