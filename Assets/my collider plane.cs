using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * we use different Collision in the plane 
 * */
public class mycolliderplane : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("the OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("the OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("the OnCollisionExit");
    }
}
