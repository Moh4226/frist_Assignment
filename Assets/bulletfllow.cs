using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfllow : MonoBehaviour
{
    Transform playerTransform;
    Rigidbody rb;
    float bulletspeed = 0.5f;
   [SerializeField] private GameObject m_bulletfllow;
   
    public static score Instance;

    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        bulletposition();

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
       if (Input.GetKeyDown(KeyCode.P))
        {
            var spheres = Instantiate(m_bulletfllow);
            spheres.transform.position = transform.position;

        }
    }
}
