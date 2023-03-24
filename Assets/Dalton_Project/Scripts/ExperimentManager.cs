using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentManager : MonoBehaviour
{
//     public GameObject targets, targetL , targetR, goal;
//     public int tNum, pNum, Trial;
//     public bool NextTrial = false;

//     private float[] sizes = new float[] {0.5f,0.6f,0.7f,0.8f,0.9f,1,1.1f,1.2f,1.3f,1.4f,1.5f};

//     private void Start()
//     {
//         sizes = RandomizeFloatArray(sizes);
//        // Trial = 1;
//     }

//     public void ReactivateTargets()
//     {
//         {
//             if (GameObject.FindWithTag("TargetBorder") == null && GameObject.Find("Goal") == null)
//             {
//                 NextTrial = true;
//             }

//             else
//             { }
//         }

//         targets.SetActive(true);
//         goal.SetActive(true);
//     }

//     public void setTargetSize(int tNum)
//     {
//        // targetL.gameObject.transform.localScale = new Vector3(sizes[tNum], sizes[tNum], sizes[tNum]);
//        targetR.gameObject.transform.localScale = new Vector3(sizes[tNum], sizes[tNum], sizes[tNum]);
//     }
    
//     public void nextTrial()
//     {
//         // if (NextTrial == true)  //added condition

//         {
//             if (NextTrial == true) 
//             {
//                 tNum++;
//                 setTargetSize(tNum % 11);
//                 // Trial = Trial + 1;

//                 NextTrial = false;
//             }
        
//             else
//             { }
//         }
//     }

//     public float[] RandomizeFloatArray(float[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             int randInt = Random.Range(0, array.Length);
//             float temp = array[i];

//             array[i] = array[randInt];
//             array[randInt] = temp;
//         }
//         return array;
//     }

//   //  public void SetNextTrial() /// added to make changing target size conditional
//    // {
//      //   if (GameObject.FindWithTag("TargetBorder") == null) ;
//        // {
//        //    NextTrial = true;
//        // }
//    // }
}
