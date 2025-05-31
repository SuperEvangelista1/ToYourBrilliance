using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerScript : MonoBehaviour
{
    public GameObject targetObject; // Drag your target GameObject here in Inspector

   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (targetObject != null)
        {
            BlockadeScript targetScript = targetObject.GetComponent<BlockadeScript>();
            if (targetScript != null)
            {
                targetScript.touchedAxe = true;
                Debug.Log("Bool activated on target!");
            }
            else
            {
                Debug.LogError("TargetScript not found on " + targetObject.name);
            }
        }
        else
        {
            Debug.LogError("TargetObject not assigned.");
        }
    }
}
