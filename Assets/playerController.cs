using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] Transform resetTransform;
    [SerializeField] GameObject player;
    [SerializeField] Camera playerHead;

    [ContextMenu("Reset Position")]
    
    public void resetPosition()
    {
        // reset the player's rotation
        var rotationAngleY = resetTransform.rotation.eulerAngles.y - 
                                playerHead.transform.rotation.eulerAngles.y;
        
        player.transform.Rotate(0, rotationAngleY, 0);

        // reset the player's position
        var distanceDiff = resetTransform.position - 
                                playerHead.transform.position;
        player.transform.position += distanceDiff;
    }




}
