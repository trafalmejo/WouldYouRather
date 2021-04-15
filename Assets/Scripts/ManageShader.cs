using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageShader : MonoBehaviour
{

    private Shader shader;
    private  Renderer rend;

    public float activeOutlineWidth = 0.15f;
    public float deactiveOutlineWidth = 0.0f;

    private float width;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer> ();
        shader = Shader.Find("Outline/Outline");
        rend.material.SetFloat("_OutlineWidth", deactiveOutlineWidth);
        width = deactiveOutlineWidth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activate(){
                   rend.material.SetFloat("_OutlineWidth", activeOutlineWidth);

    }
    public void deactivate(){
                   rend.material.SetFloat("_OutlineWidth", deactiveOutlineWidth);

    }
    public void toggle(){
        width = rend.material.GetFloat("_OutlineWidth");
        if(width == deactiveOutlineWidth){
        rend.material.SetFloat("_OutlineWidth", activeOutlineWidth);

        }else if(width == activeOutlineWidth){
        rend.material.SetFloat("_OutlineWidth", deactiveOutlineWidth);

        }
    }
}
