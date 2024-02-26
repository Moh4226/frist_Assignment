using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class creategun : MonoBehaviour
{
    [SerializeField] private GameObject m_prefeb1;
   // [SerializeField] private float m_gun;
    [SerializeField] private EnemyData m_data;
    private Coroutine m_Coroutine;
    private Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Coroutine= StartCoroutine(Update1());
        m_Rigidbody = GetComponent<Rigidbody>();
        //  InvokeRepeating("Update1", 0.0f, m_data.Delay);
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


        if (Input.GetKeyDown(KeyCode.X))
        {
            StopCoroutine(m_Coroutine);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            m_Coroutine = StartCoroutine(Update1());
        }

    }

    private IEnumerator Update1()
    {
        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                Shoot();
                yield return new WaitForSeconds(0.3f);
            }

            yield return new WaitForSeconds(m_data.Delay);
        }










        /*while (true)
        {
            yield return new WaitForSeconds(m_data.Delay);
            var spheres = Instantiate(m_prefeb1);
            spheres.transform.position = transform.position;
            yield return new WaitForSeconds(m_data.Delay / 3);
            var spheres1 = Instantiate(m_prefeb1);
            spheres1.transform.position = transform.position;
            yield return new WaitForSeconds(m_data.Delay / 3);
            var spheres2 = Instantiate(m_prefeb1);
            spheres2.transform.position = transform.position;

            yield return new WaitForSeconds(m_data.Delay);
            transform.position += Vector3.down * 1.0f;
            var spheres3 = Instantiate(m_prefeb1);
            spheres3.transform.position = transform.position;
            yield return new WaitForSeconds(m_data.Delay / 3);
            var spheres4 = Instantiate(m_prefeb1);
            spheres4.transform.position = transform.position;
            yield return new WaitForSeconds(m_data.Delay / 3);
            var spheres5 = Instantiate(m_prefeb1);
            spheres5.transform.position = transform.position;
            transform.position += Vector3.up * 1.0f;

            /*for (int i = 0; i < 10; i++) {
               m_Rigidbody.position= Vector3.up;
                yield return new WaitForSeconds(m_data.Delay);
                var spheres = Instantiate(m_prefeb1);
                spheres.transform.position = transform.position;
                yield return new WaitForSeconds(m_data.Delay / 3);
                var spheres1 = Instantiate(m_prefeb1);
                spheres1.transform.position = transform.position;
                yield return new WaitForSeconds(m_data.Delay / 3);
                var spheres2 = Instantiate(m_prefeb1);
                spheres2.transform.position = transform.position;
            }
            for (int i = 0; i < 10; i++) {
                m_Rigidbody.position = Vector3.zero;
                yield return new WaitForSeconds(m_data.Delay);


            }

            for (int i = 0; i < 10; i++)
            {
                m_Rigidbody.position= Vector3.down ;
                yield return new WaitForSeconds(m_data.Delay);
                var spheres = Instantiate(m_prefeb1);
                spheres.transform.position = transform.position;
                yield return new WaitForSeconds(m_data.Delay / 3);
                var spheres1 = Instantiate(m_prefeb1);
                spheres1.transform.position = transform.position;
                yield return new WaitForSeconds(m_data.Delay / 3);
                var spheres2 = Instantiate(m_prefeb1);
                spheres2.transform.position = transform.position;
            }
            for (int i = 0; i < 10; i++)
            {
                m_Rigidbody.position = Vector3.zero;
                yield return new WaitForSeconds(m_data.Delay);


            }*/




    }
    private void Shoot()
    {
        GameObject newBullet = Instantiate(m_prefeb1, transform.position + Vector3.up, Quaternion.identity);
        newBullet.GetComponent<hitplayer>().Init(m_data.bulte_speed, true, m_data.AutoAim);
    }



    // var spheres = Instantiate(m_prefeb1);
    //  spheres.transform.position = transform.position;



}
