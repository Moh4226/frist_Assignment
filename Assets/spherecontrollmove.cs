using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontrollmove : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_Life;
    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, m_Life);

    }

   

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = Vector3.forward * m_Speed * Time.deltaTime;
        //m_Rigidbody.AddForce(Vector3.forward * m_Speed); ;


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shoot")) {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        
        
        
        }
    }


}
