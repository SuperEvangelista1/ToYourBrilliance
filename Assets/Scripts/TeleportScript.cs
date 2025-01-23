using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject anchorpoint1;
    public GameObject anchorpoint2;
    public GameObject anchorpoint3;
    public GameObject anchorpoint4;
    public GameObject anchorpoint5;
    public GameObject anchorpoint6;
    public GameObject anchorpoint7;
    public GameObject anchorpoint8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "AnchorStart")
       {
            transform.position = anchorpoint1.gameObject.transform.position;
       }
        if (collision.gameObject.tag == "AnchorStart2")
        {
            transform.position = anchorpoint2.gameObject.transform.position;

        }
        if (collision.gameObject.tag == "AnchorStart3")
        {
            transform.position = anchorpoint3.gameObject.transform.position;
        }
        if (collision.gameObject.tag == "AnchorStart4")
        {
            transform.position = anchorpoint4.gameObject.transform.position;
        }
        if (collision.gameObject.tag == "AnchorStart5")
        {
            transform.position = anchorpoint5.gameObject.transform.position;
        }
        if (collision.gameObject.tag == "AnchorStart6")
        {
            transform.position = anchorpoint6.gameObject.transform.position;
        }
        if (collision.gameObject.tag == "AnchorStart7")
        {
            transform.position = anchorpoint7.gameObject.transform.position;
        }
        if (collision.gameObject.tag == "AnchorStart8")
        {
            transform.position = anchorpoint8.gameObject.transform.position;
        }
    }
}
