using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class StopTrialController : MonoBehaviour
{
    public Session session;

    void StopTrial()
    {
        session.EndCurrentTrial();
    }
}
