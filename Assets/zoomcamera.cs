using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class zoomcamera : MonoBehaviour
{
    public float zoomLevel;
    public float sensitivity = 1;
    public float speed = 30;
    public float maxZoom = 30;
    float zoomInput = 90;
    float zoomPosition;
    public Transform player_transform;
    private PlayerAction m_PlayerAction;


    private void Awake()
    {
        m_PlayerAction = new PlayerAction();
        if (m_PlayerAction == null)
        {
            Debug.LogError("playertrasform is null for camera");
        }
        m_PlayerAction.Movement.zoom.performed += context => zoom(context.ReadValue<float>());
    }


    void zoom(float zoomInput)
    {

        Debug.Log(zoomInput);
        zoomLevel += Input.mouseScrollDelta.y * sensitivity;
        zoomLevel = Mathf.Clamp(zoomLevel, 0, maxZoom);
        zoomPosition = Mathf.MoveTowards(zoomPosition, zoomLevel, speed * Time.deltaTime);
        transform.position = player_transform.position + (transform.forward * zoomPosition);



    }
    // Start is called before the first frame update
    private void OnEnable()
    {
        m_PlayerAction.Movement.Enable();
    }
    private void OnDisable()
    {
        m_PlayerAction.Movement.Disable();
    }
}
