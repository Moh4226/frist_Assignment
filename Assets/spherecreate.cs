using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecreate : MonoBehaviour
{
    [SerializeField] private GameObject m_prefeb1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
           var spheres=  Instantiate(m_prefeb1);
            spheres.transform.position = transform.position;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("Update1", 0.0f, 0.5f);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke();


        }





    }

    void Update1()
    {
        
            var spheres = Instantiate(m_prefeb1);
            spheres.transform.position = transform.position;


    }
}
