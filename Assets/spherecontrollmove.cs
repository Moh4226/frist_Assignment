using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontrollmove : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_Life;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_Life);

    }

   

    // Update is called once per frame
    void Update()
    {

            transform.position += Vector3.forward * m_Speed * Time.deltaTime;

    }


   

}
