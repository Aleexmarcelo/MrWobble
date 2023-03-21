using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyTrigger : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject scriptObject;
    public string scriptVariableName;

    private void OnDestroy()
    {
        scriptObject.GetComponent<Timer>().enabled = true;
        //  scriptObject.GetComponent<Timer>().starter = true;
    }
}
