using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.forward*m_Speed;
        
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.forward*m_Speed;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*m_Speed;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= Vector3.left * m_Speed;

        }
    }
}
