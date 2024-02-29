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

    void Movement() {
        //transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);

        var animator = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.UpArrow))
            animator.SetBool("Forward", true);
        if (Input.GetKeyUp(KeyCode.UpArrow))
            animator.SetBool("Forward", false);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            animator.SetBool("Back", true);
        if (Input.GetKeyUp(KeyCode.DownArrow))
            animator.SetBool("Back", false);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            animator.SetBool("Left", true);
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            animator.SetBool("Left", false);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            animator.SetBool("Right", true);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            animator.SetBool("Right", false);







    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // transform.position += Vector3.forward * m_speed * Time.deltaTime;
            m_Rigidbody.AddForce(transform.forward * m_speed);
            Movement();
            transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);


        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            m_Rigidbody.velocity = Vector3.zero;
            Movement();


        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Rigidbody.AddForce(-transform.forward * m_speed);

            Movement();
            transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            m_Rigidbody.velocity = Vector3.zero;
            Movement();

        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody.AddForce(-transform.right * m_speed);
            Movement();
            transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            m_Rigidbody.velocity = Vector3.zero;
            Movement();

        }



        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.AddForce(transform.right * m_speed);
            Movement();
            transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            m_Rigidbody.velocity = Vector3.zero;
            Movement();

        }
        //transform.position += Vector3.forward * m_speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);

    }
}
