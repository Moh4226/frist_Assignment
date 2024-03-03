using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecreate : MonoBehaviour
{
    [SerializeField] private GameObject m_prefeb1;
    private PlayerAction m_PlayerAction;

    // Start is called before the first frame update
    void Awake()
    {
        m_PlayerAction = new PlayerAction();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.timeScale > 0)
        {
            /* if (Input.GetKeyDown(KeyCode.H))
             {
                 Movement();
                 var spheres = Instantiate(m_prefeb1);
                 spheres.transform.position = transform.position;

             }

             if (Input.GetKeyDown(KeyCode.J))
             {

                 InvokeRepeating("Update1", 0.0f, 0.5f);

             }
             if (Input.GetKeyUp(KeyCode.Space))
             {
                // Movement();

                 CancelInvoke();



             }*/

            if (m_PlayerAction.Movement.shoot.WasPressedThisFrame())
            {
                var spheres = Instantiate(m_prefeb1);
                spheres.transform.position = transform.position;
                Movement();
            }
            if (m_PlayerAction.Movement.shootcons.WasPressedThisFrame()) {
                Movement();
                InvokeRepeating("Update1", 0.0f, 1f);



            }
            if (m_PlayerAction.Movement.shootcons.WasReleasedThisFrame()) {
                CancelInvoke();

            }


        }

        else {
            Debug.Log("the game is pause");
        
        }



    }
    void Movement() {
        var animator = GetComponent<Animator>();

        animator.SetTrigger("shoot");
      




        // animator.SetBool("shooting", false);


    }
    void Update1()
    {
       

        var spheres = Instantiate(m_prefeb1);
        spheres.transform.position = transform.position +transform.forward;

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
