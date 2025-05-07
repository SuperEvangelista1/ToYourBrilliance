using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    public GameObject NPC;
    public Vector3 NPCPos;
    public float PopUpTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PopUpTimer += Time.deltaTime;
        if(PopUpTimer >= 250F)
        {
            Instantiate(NPC, NPCPos, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
