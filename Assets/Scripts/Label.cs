using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Label : MonoBehaviour
{
    private TextMeshProUGUI textObject;
    private GameObject labeledObject;
    private Camera cam;

    private void Start()
    {
        textObject = GetComponentInChildren<TextMeshProUGUI>();
        cam = Camera.main;
        transform.LookAt(cam.transform.position);
        ShowLabel();
    }
    void ShowLabel()
    {
        textObject.text = labeledObject.name;
    }

    private void Update()
    {
        if (cam.velocity.magnitude > 0)
        {
            transform.LookAt(cam.transform.position);
        }
    }

    void HideLabel()
    {
        textObject.text = "";
    }
}
