using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitplayer : MonoBehaviour
{
    [SerializeField] private float m_Speed=0.05f;
    [SerializeField] private float m_Life=10.0f;
    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, m_Life);

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        m_Rigidbody.velocity = Vector3.left * m_Speed;
        //m_Rigidbody.AddForce(Vector3.forward * m_Speed); ;


    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("player"))
        {
            //Destroy(col.gameObject);
           // Destroy(gameObject);
            Debug.Log("you dead-------------------------------------");




        }
    }


}
