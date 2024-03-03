using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class spherecontrollmove : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_Life;
    private Rigidbody m_Rigidbody;
    public Transform target;
    Vector3 PlayerLookdirection;



    // Start is called before the first frame update
    void Start()
    {
        PlayerLookdirection = GameObject.FindGameObjectWithTag("player").transform.forward;
        m_Rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, m_Life);

    }
   


    // Update is called once per frame
    void Update()
    {

        m_Rigidbody.velocity = PlayerLookdirection * m_Speed ;

        //m_Rigidbody.AddForce(Vector3.forward * m_Speed); ; 
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shoot")) {
           
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.Instance.writescore();


        }
        
                

        /*if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("you dead");




        }*/
    }


}
