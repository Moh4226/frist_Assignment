using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class creategun : MonoBehaviour
{
    [SerializeField] private GameObject m_prefeb1;
   // [SerializeField] private float m_gun;
    [SerializeField] private EnemyData m_data;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Update1", 0.0f, m_data.Delay);
    }

    // Update is called once per frame
    void Update()
    {
        
        // var spheres = Instantiate(m_prefeb1);
        //   spheres.transform.position = transform.position;
        /* int i=10;
         if (i > 0)
         {
             for (i = 10; i > 0; --i)
             {
                 InvokeRepeating("Update1", 0.1f, 10f);

             }
         }
         else { 
              i= 10;

         }*/
        /*
                if ()
                {
                    var spheres = Instantiate(m_prefeb1);
                    spheres.transform.position = transform.position;

                }*/




    }

    void Update1()
    {

        var spheres = Instantiate(m_prefeb1);
        spheres.transform.position = transform.position;


    }
}
