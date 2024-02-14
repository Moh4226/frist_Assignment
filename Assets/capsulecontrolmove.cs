using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulecontrolmove : MonoBehaviour
{
    [SerializeField] private float m_speed;
    private Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // transform.position += Vector3.forward * m_speed * Time.deltaTime;
            m_Rigidbody.AddForce(Vector3.forward * m_speed);

        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Rigidbody.AddForce(Vector3.back * m_speed);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody.AddForce(Vector3.left * m_speed);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.AddForce(Vector3.right * m_speed);

        }

        


    }
}
