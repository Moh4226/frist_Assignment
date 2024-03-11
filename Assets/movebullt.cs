using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * this class for move the bullte
 */
public class movebullt : MonoBehaviour
{
    // Start is called before the first frame update
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
    void Update()
    {
        Vector3 PlayerFacing = (playerTransform.position - transform.position).normalized;
        rb.velocity = Vector3.zero;
        rb.velocity += PlayerFacing * bulletspeed;

    }
}
