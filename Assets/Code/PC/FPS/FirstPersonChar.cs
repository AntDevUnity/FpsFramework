using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonChar : MonoBehaviour {

    public Rigidbody CharBody;
    public Transform CharNode;
    public Camera CharCam;
    public float XDrag = 0.7f;
    public float YDrag = 0.6f;

    public float MXDrag = 0.7f;
    public float MYDrag = 0.7f;

    public float XMoveMulti = 8.4f;
    public float YMoveMulti = 0.6f;

    private float XI = 0;
    private float YI = 0;

    private float MXI = 0;
    private float MYI = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Movement

        float mx = Input.GetAxis("Horizontal") * XMoveMulti;
        float my = Input.GetAxis("Vertical")*YMoveMulti;

        Debug.Log("MX:" + mx + " MY:" + my);

        MXI += mx;
        MYI += my;


        CharBody.AddRelativeForce(new Vector3(MXI, 0, MYI));

        MXI *= MXDrag;
        MYI *= MYDrag;
        // - Mouse Look

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        YI = YI + y;

        XI += x;

        XI = XI * XDrag;
        YI = YI * YDrag;

        CharNode.Rotate(new Vector3(0, XI, 0));
        CharCam.transform.Rotate(new Vector3(-YI, 0, 0));

       // Debug.Log("Y:" + CharCam.transform.eulerAngles.x);

        var ca = CharCam.transform.eulerAngles;

        if (ca.x > 45 && ca.x < 120)
        {
            ca.x = 45;
            CharCam.transform.eulerAngles = ca;
        }
        if(ca.x > 180 && ca.x < 315)
        {
            ca.x = 315;
           CharCam.transform.eulerAngles = ca;
        }

	}
}
