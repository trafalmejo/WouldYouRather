using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float rayLenght;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, rayLenght, layerMask)){
                Debug.Log(hit.collider.name);
                Toggle t = hit.collider.gameObject.GetComponent<Toggle>();
                Debug.Log("T: " + t.isOn);
                t.isOn = !t.isOn;
            }


        }    
    }
}
