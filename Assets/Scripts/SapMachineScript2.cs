using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapMachineScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mayor;
    public Vector3 MPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(mayor, MPos, Quaternion.identity);
    }
}
