using UnityEngine;
using System.Collections;

public class CameraMotion : MonoBehaviour {
	#region Constants

	public Transform Target;
	private const float cameraSpeed = 2;

	#endregion
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(cameraSpeed * (Target.position.x - transform.position.x) * Time.deltaTime, 
			cameraSpeed * (Target.position.y - transform.position.y) * Time.deltaTime));
	}
}
