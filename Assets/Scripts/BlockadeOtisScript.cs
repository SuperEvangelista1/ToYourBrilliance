using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockadeOtisScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool treeGone;
    void Start()
    {
        treeGone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(treeGone == true)
        {
            Destroy(gameObject);
        }
    }
}
