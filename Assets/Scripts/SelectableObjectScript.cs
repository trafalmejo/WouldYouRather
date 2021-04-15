using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectableObjectScript : MonoBehaviour
{
    private Toggle toggle;
    public GameObject child;
    public GameObject title;
    private TextMeshPro nameObject;

    public Material childMaterial;
    private Shader shader;
    private  Renderer rend;

    private Floating floating;

    
    public float activeOutlineWidth = 0.05f;
    public float deactiveOutlineWidth = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Add to toggleGroup
        toggle = gameObject.GetComponent<Toggle>();
        toggle.group = transform.parent.gameObject.GetComponent<ToggleGroup>();
        //Get child
        rend = child.GetComponent<Renderer> ();
        shader = Shader.Find("Outline/Outline");
        rend.material.SetFloat("_OutlineWidth", deactiveOutlineWidth);
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });
        //change Rotation
        child.transform.Rotate(0.0f, 0.0f, 15.0f, Space.Self);
        //add material
        child.GetComponent<Renderer>().material = childMaterial;


        //add floating behaviour
        child.AddComponent<Floating>();
        floating = child.GetComponent<Floating>();
        title.AddComponent<Floating>().degreesPerSecond = 0;
        title.GetComponent<Floating>().amplitude = 0.05f;
        //title.transform.parent = child.transform;


        nameObject = title.GetComponent<TextMeshPro>();
        nameObject.SetText(child.name);
        title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Update State

        
    }
    
    public void ToggleValueChanged(Toggle change){

            if(toggle.isOn){
        rend.material.SetFloat("_OutlineWidth", activeOutlineWidth);
        floating.changeAmplitude(0.2f);
        floating.degreesPerSecond = 100.0f;
        title.SetActive(true);

            }else{
        rend.material.SetFloat("_OutlineWidth", deactiveOutlineWidth);
        floating.changeAmplitude(0.025f);
        floating.degreesPerSecond = 15.0f;
        title.SetActive(false);

    }
    }
}
