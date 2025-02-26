using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class ObjectValue
{
    public string objectName; // Name of the object
    public int value;        // Value associated with the object (e.g., how many times it's picked up)

    public ObjectValue(string name)
    {
        objectName = name;
        value = 1;  // Initial value when the object is picked up for the first time
    }
}
