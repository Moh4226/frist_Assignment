using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOtween : MonoBehaviour
{
    [SerializeField] private GameObject m_enemyprefab;
    [SerializeField] private Transform m_enemySpawn;


    // Start is called before the first frame update
    void Start()
    {
       // m_enemySpawn = GameObject.FindGameObjectWithTag("gun");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EnterOnWar() { 
        
    
    
    
    
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="player")
        {
            Debug.Log("you enter the zone");
            StartCoroutine(create(5));

        }
    }

    IEnumerator create(int amount) {
        int enemycreate = 0;
        while (enemycreate<amount) {
            Vector3 spawnpos = m_enemySpawn.position;
            yield return new WaitForSeconds(1.0f);
            spawnpos.x += Random.Range(-10, 10);
            spawnpos.y += Random.Range(-10, 10);
            Instantiate(m_enemyprefab, spawnpos, Quaternion.identity);
            enemycreate++;



        }



    }
}
