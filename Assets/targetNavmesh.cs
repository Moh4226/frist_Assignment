using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class targetNavmesh : MonoBehaviour
{
    [SerializeField] private Transform target;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
