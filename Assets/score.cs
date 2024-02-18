using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class score : MonoBehaviour
{
    [SerializeField] private static TextMeshProUGUI m_Text;
    [SerializeField] private static int m_Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = GameObject.Find("scorekill").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public static void writescore() {
        m_Score++;
        m_Text.text = m_Score.ToString();
    
    }
}
