using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform target;
    public float distanceUp = 10f;
    public float distanceAway = 10f;
    public float smooth = 2f;
    public float camdepthsmooth = 5f;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Car").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if((Input.mouseScrollDelta.y<0&&Camera.main.fieldOfView>=3)||
             Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camdepthsmooth * Time.deltaTime;
        }
    }
    private void LateUpdate()
    {
        Vector3 disPos = target.position + Vector3.up * distanceUp - target.forward * distanceAway;
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        transform.LookAt(target.position);
    }
}
