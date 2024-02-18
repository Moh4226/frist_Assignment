using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    void FixedUpdate()
    {
        m_Rigidbody.velocity = Vector3.forward * m_Speed ;
        //m_Rigidbody.AddForce(Vector3.forward * m_Speed); ; 
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shoot")) {
           
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.writescore();


        }
        
        FixedUpdate();

        /*if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("you dead");




        }*/
    }


}
