using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    Rigidbody rb;
    float bulletspeed = 0.5f;
    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    public void bulletposition()
    {
        playerTransform = FindAnyObjectByType<capsulecontrolmove>().gameObject.transform;




    }






    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerFacing = (playerTransform.position - transform.position).normalized;
        // rb.velocity = Vector3.zero;
        rb.velocity += PlayerFacing * bulletspeed;
    }
}
