using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject cube,sphere;
   // public trialEnvironment other;
    public float ObjectSize;

    public GameObject experimentManager;

    // public void update (){
    //     experimentManager = GameObject.Find("ExperimentManager");
    //     ObjectSize = experimentManager.GetComponent<trialEnvironment>().heldObject_size;
    // }

    public void SpawnObject(int SpawnerIndex)
    {
        if (SpawnerIndex == 0)
        {
            if (GameObject.FindWithTag("ThrowableCube") != null)
            {
                Debug.Log("Object Spawner Do Nothing");
            }
            else
            {
                Instantiate(cube, transform.position, transform.rotation, null);
                //cube.transform.localScale = ObjectSize * new Vector3(1f, 1f, 1f);

            }
        }

        else if (SpawnerIndex == 1)
        {
            Instantiate(sphere, transform.position, transform.rotation, null);
        }
    }
}