using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class spheredistance : MonoBehaviour
{
    [SerializeField] public Vector3 _startPosition;
    [SerializeField] public Vector3 _endposition;
    [SerializeField] public Length m_Lenght;
    [SerializeField] public float m_smallLengh;
    [SerializeField] public Vector3 piont;
    [SerializeField] public Vector3 piont2;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
        _endposition = _startPosition * 2.1f;
      

    }

    // Update is called once per frame
    void Update()
    {
        // _endposition = _startPosition * m_Lenght;
        piont = new Vector3(-15, -15,-15);
        piont2 = new Vector3(-15,-15,15);
        Debug.DrawLine(_startPosition,  _endposition);
        m_Lenght =Vector2.Distance(_startPosition,_endposition)*0.6f;
        Debug.DrawLine(_endposition, _endposition+piont);
        Debug.DrawLine(_endposition, _endposition + piont2);
        Debug.DrawLine(_endposition + piont, _endposition + piont2);

           

    }


}
