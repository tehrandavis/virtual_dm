﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// add the UXF namespace
using UXF;

public class ExperimentGenerator : MonoBehaviour
{     
    public float targetSize;
    // generate the blocks and trials for the session.
    // the session is passed as an argument by the event call.
    public void Generate(Session session)
    {
        // targetSize = session.GetFloat("left_target_size");
        // // generate a single block with 10 trials.
        // int numTrials = 10;
        // session.CreateBlock(numTrials);
    }
}