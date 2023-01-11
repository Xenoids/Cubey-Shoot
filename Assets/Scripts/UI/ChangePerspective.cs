using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePerspective : MonoBehaviour
{

    [Header("Camera")]

    #region Camera
    public GameObject Third_Camera;
    public GameObject First_Camera;

    #endregion

    public string ThirdCamTag;
    public string FirstCamTag;

    public Canvas canvas;


    // Start is called before the first frame update
    void Start()
    {
        Third_Camera = GameObject.FindGameObjectWithTag(ThirdCamTag);

        First_Camera = GameObject.FindGameObjectWithTag(FirstCamTag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_First()
    {
        Third_Camera.SetActive(false);
        First_Camera.SetActive(true);
        canvas.worldCamera = First_Camera.GetComponent<Camera>();
    }

    public void Change_Third()
    {
        Third_Camera.SetActive(true);
        First_Camera.SetActive(false);
        canvas.worldCamera = Third_Camera.GetComponent<Camera>();
    }
}
