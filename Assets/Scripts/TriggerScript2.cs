using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetGameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (targetGameObject != null)
        {
            BlockadeOtisScript targetScript = targetGameObject.GetComponent<BlockadeOtisScript>();
            if (targetScript != null)
            {
                targetScript.treeGone = true;
            }
        }
    }
}
