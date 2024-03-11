using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/*
 * this class for camera player 3D
 * */
public class cameraPlayer : MonoBehaviour
{
    public capsulecontrolmove player;
    public GameObject playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    float rotationX = 0;
    [SerializeField]float horizitalSens = 10f;
    private PlayerAction m_PlayerAction;
    private Vector2 mouseInput;
   // public float turnSpeed = 0.40f;
    public Transform player_transform;
    float initialcameraoffset;
    Vector3 cameraRotation;
 









    // Start is called before the first frame update
    private void Awake()
    {
        m_PlayerAction = new PlayerAction();
        if (m_PlayerAction == null) {
            Debug.LogError("playertrasform is null for camera");
        }
        m_PlayerAction.Movement.rotation.performed += context => mouseInput = context.ReadValue<Vector2>();
        m_PlayerAction.Movement.zoom.performed += context => zoom(context.ReadValue<float>());
    }
    void FireRay() {
        
       
        Ray ray =new Ray(transform.position,transform.forward);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Debug.DrawRay(ray.origin,ray.direction*10);
        Debug.Log("number of hit" + hit.collider);
    
    
    }
    private void Start()
    {
        player_transform= GameObject.FindGameObjectWithTag("player").transform;
        initialcameraoffset=Vector3.Distance( transform.position, player_transform.position);
        cameraRotation = transform.rotation.eulerAngles;


    }
    void FixedUpdate()
    {
        


    }
    private void Update()
    {


        float rotationY = horizitalSens * mouseInput.x * Time.deltaTime;
        mouseInput = Vector2.zero;
        Vector3 playerRotation = player_transform.rotation.eulerAngles;
        playerRotation.y= rotationY;
        player_transform.rotation=Quaternion.Euler(playerRotation);
        FireRay();
        if (Input.GetAxis("Mouse X")!=0) {
            cameraRotation.y += Input.GetAxis("Mouse X");
            

        }
        //rotato camera
        transform.eulerAngles = cameraRotation;
        Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
        //position camera
        transform.position =-cameraLookDirection*initialcameraoffset+player_transform.position;

        //Rotate player
        Vector3 LookPlayer = player_transform.eulerAngles;
        LookPlayer.y = transform.rotation.eulerAngles.y;
        player_transform.eulerAngles = LookPlayer;



        /*this code use for see the player right and left
         * 
         * transform.position = player_transform.position + initialcameraoffset;
         Vector3 directiontoplayer = (player_transform.position - transform.position).normalized;
         player = GameObject.Find("Capsule").GetComponent<capsulecontrolmove>();
         rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
         rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
         player.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
         transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);*/


        /* else {
             transform.position = player_transform.position + initialcameraoffset;
             Vector3 directiontoplayer = (player_transform.position - transform.position).normalized;
             transform.rotation = Quaternion.LookRotation(directiontoplayer);

        
         }*/
        



    }
    void zoom(float zoominput) {
       
    }
   
    private void OnEnable()
    {
        m_PlayerAction.Movement.Enable();
    }
    private void OnDisable()
    {
        m_PlayerAction.Movement.Disable();
    }
}
    // Update is called once per frame

