using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class score : MonoBehaviour
{
    public static score Instance;
    [SerializeField] private static TextMeshProUGUI m_Text;
    [SerializeField] private static int m_Score = 0;
    [SerializeField] AudioSource deadsound;

    // Start is called before the first frame update
    void Start()
    {
        Instance=this;
        m_Text = GameObject.Find("scorekill").GetComponent<TextMeshProUGUI>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void writescore() {
        m_Score++;
        m_Text.text = m_Score.ToString();
        deadsound.Play();
    }
}
