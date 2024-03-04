using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partical_system : MonoBehaviour
{
    Vector3 smoke;
    Vector3 goal;
    // Start is called before the first frame update
    void Start()
    {
        smoke = GameObject.FindGameObjectWithTag("smoke").transform.position;
        goal = GameObject.FindGameObjectWithTag("shoot").transform.position;
        ParticleSystem part = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            var part = GetComponent<ParticleSystem>();
            smoke.y = goal.y;
            smoke.x = goal.x;
            smoke.z = goal.z;
            Destroy(collision.gameObject);
            part.Play();
            Destroy(gameObject,part.main.duration);


        }



        /*if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("you dead");




        }*/
    }
}
