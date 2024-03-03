using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulecontrolmove : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_Force;
    private Rigidbody m_Rigidbody;
    private PlayerAction m_PlayerAction;
    private Vector2 move;
    // Start is called before the first frame update

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_PlayerAction = new PlayerAction();
    }

    void Movement() {
        //transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);

        var animator = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.W))
            animator.SetBool("Forward", true);
        if (Input.GetKeyUp(KeyCode.W))
            animator.SetBool("Forward", false);
        if (Input.GetKeyDown(KeyCode.S))
            animator.SetBool("Back", true);
        if (Input.GetKeyUp(KeyCode.S))
            animator.SetBool("Back", false);
        if (Input.GetKeyDown(KeyCode.A))
            animator.SetBool("Left", true);
        if (Input.GetKeyUp(KeyCode.A))
            animator.SetBool("Left", false);
        if (Input.GetKeyDown(KeyCode.D))
            animator.SetBool("Right", true);
        if (Input.GetKeyUp(KeyCode.D))
            animator.SetBool("Right", false);
        if (Input.GetKey(KeyCode.Space))
            animator.SetTrigger("jump");







    }
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.UpArrow))
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
        */
        move = m_PlayerAction.Movement.Move.ReadValue<Vector2>();
       
      
        m_Rigidbody.velocity = new Vector3(move.x * m_speed, m_Rigidbody.velocity.y, move.y * m_speed);

        Debug.Log(m_Rigidbody.velocity);

        
        if (m_PlayerAction.Movement.Jump.WasPressedThisFrame())
            {
                m_Rigidbody.AddForce(Vector3.up * m_Force,ForceMode.Impulse);
            m_PlayerAction.Movement.Move.bindings.Equals(move.x);
               // transform.rotation = Quaternion.LookRotation(m_Rigidbody.velocity);
            }
        Movement();













    }
    private void OnEnable()
    {
        m_PlayerAction.Movement.Enable();
    }
    private void OnDisable()
    {
        m_PlayerAction.Movement.Disable();
    }
}
