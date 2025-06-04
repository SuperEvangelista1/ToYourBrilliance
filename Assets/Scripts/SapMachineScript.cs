using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapMachineScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject quirrel;
    public Vector3 QPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(quirrel, QPos, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
