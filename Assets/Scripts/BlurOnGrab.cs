using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BlurOnGrab : MonoBehaviour
{
    [SerializeField]
    private GameObject padre;
    [SerializeField]
    private Volume blur;


    int blurLayer = 0;

    // Start is called before the first frame update
    void Start()
    {
        blurLayer = LayerMask.NameToLayer("NoBlur");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGrab()
    {
        // Check if random chance is set
        padre.layer = blurLayer;
        blur.weight = 0.9f;
    }

    public void OnRelease()
    {
        // Check if random chance is set
        padre.layer = 0;
        blur.weight = 0;
    }
}
