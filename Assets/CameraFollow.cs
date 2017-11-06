using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed =  .1f;

    private Vector3 currentVelocity;
	
	// Update is called once per frame
	void LateUpdate () {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            //transform.position = Vector3.Lerp(transform.position, newPosition, smoothSpeed);
            transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref currentVelocity, smoothSpeed);
        }
	}
}
