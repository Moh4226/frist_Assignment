using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicked : MonoBehaviour
{
    // Start is called before the first frame update


    private void Update()
    {
        Clicked();
    }
    void Clicked() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitData;
            if (Physics.Raycast(ray, out hitData))
            {
                Debug.Log("name of objectis -------" + hitData.collider);


            }
        }


    }
}
