using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/*
 * this class for Make enemy chase the player 
 */
public class targetNavmesh : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private EnemyData m_data;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
        GetComponent<NavMeshAgent>().speed = m_data.enemy_speed;
    }
}
