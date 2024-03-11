using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * this class for conver the game to asynchrons
 * */
public class Asynchro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
