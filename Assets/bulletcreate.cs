using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcreate : MonoBehaviour
{
    [SerializeField] private GameObject m_prefeb1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {
           
                var spheres = Instantiate(m_prefeb1);
               

            
           

        }
        else
        {
            Debug.Log("the game is pause");

        }



    }

    
}
