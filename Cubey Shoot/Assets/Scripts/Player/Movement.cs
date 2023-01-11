using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]

    #region Movement
    public float speed = 50f;

    private float Xinput;
    private float Yinput;

    #endregion

    [SerializeField]
    private string inputHorizontal;

    [SerializeField]
    private string inputVertical;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        InputMovement();
    }

    private void InputMovement()
    {
        Xinput = Input.GetAxisRaw(inputHorizontal);
        Yinput = Input.GetAxisRaw(inputVertical);

        rb.velocity = new Vector3(Xinput, rb.velocity.y,Yinput) * speed;
    }
}
