using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockadeScript : MonoBehaviour
{

    public bool touchedAxe;

    // Start is called before the first frame update
    void Start()
    {
        touchedAxe = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(touchedAxe == true)
        {
            Destroy(gameObject);
        }

    }
   
    
}
    
