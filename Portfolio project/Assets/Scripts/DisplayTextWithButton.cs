using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayTextWithButton : MonoBehaviour
{
    [SerializeField] private KeyCode theKey;
    [SerializeField] private TextMeshPro text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(theKey))
        {
            ReverseTextEnable();
        }
    }

    private void ReverseTextEnable()
    {
        text.enabled = !text.enabled;
    }
}
