using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionUIScript : MonoBehaviour
{
        private Camera maincamera;

    // Start is called before the first frame update
    void Start()
    {
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Canvas selectioncanvas =  gameObject.GetComponent<Canvas>();
        selectioncanvas.renderMode = RenderMode.ScreenSpaceCamera;
        selectioncanvas.worldCamera = maincamera;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
