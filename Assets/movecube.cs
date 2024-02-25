using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movecube : MonoBehaviour
{
    [SerializeField] public Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + new Vector3(Mathf.Sin(-Time.time), Mathf.Cos(-Time.time), 0.0f);

    }
}
