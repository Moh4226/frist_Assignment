using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * this class for move the enemy
 * */
public class EnemyController : MonoBehaviour
{
    private score m_scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        m_scoreCounter = FindObjectOfType<score>();
        //StartCoroutine(MovementCoroutine());
    }

    private IEnumerator MovementCoroutine()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        while (true)
        {
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.up;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.down;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            m_scoreCounter.writescore();
            Destroy(gameObject);
        }
    }
}
