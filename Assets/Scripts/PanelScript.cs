using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Panel.SetActive(!Panel.activeSelf);//toggles its state of activity aka checks and unchecks the box that keeps an item visable or in use
        }
        
    }
    
    

    
}
