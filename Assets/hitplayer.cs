using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * in this class if the bullet of enemy hit the player or no and we have two way 
 * frist the bullet find the direction of player 
 * Second the bullet follow the player 
 * */
public class hitplayer : MonoBehaviour
{
    // [SerializeField] private float m_Speed=0.05f;
    [SerializeField] private EnemyData m_data;
    [SerializeField] private float m_Life=10.0f;
    private Rigidbody m_Rigidbody;
    private capsulecontrolmove m_player;
    private Quaternion m_quat;


    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, m_Life);

    }


    public void Init(float speed, bool lookAtPlayer, bool followPlayer)
    {
        m_data.enemy_speed = speed;

        if (lookAtPlayer)
        {
            m_player = FindObjectOfType<capsulecontrolmove>();
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
            m_data.followPlayer = followPlayer;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (m_data.followPlayer)
        {
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
        }

        //transform.position += Vector3.forward * m_speed * Time.deltaTime;
        m_Rigidbody.velocity = m_quat * Vector3.forward * m_data.enemy_speed;


    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("player"))
        {
            //Destroy(col.gameObject);
           // Destroy(gameObject);
            Debug.Log("you dead-------------------------------------");




        }
    }


}
