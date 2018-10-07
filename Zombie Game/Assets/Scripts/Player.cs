using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

	#region Properties

	public float XForce { get; private set; }
	public float YForce { get; private set; }
	public Rigidbody2D Body { get { return GetComponent<Rigidbody2D>(); } }
	public Collider2D PlayerCollider { get { return GetComponent<Collider2D>(); } }

	#endregion

	#region Constants

	private const float Acceleration = 50;
	private const float JumpAcceleration = 5;

	#endregion

	#region Editor data

	public LayerMask GroundLayer;

	#endregion

	// Use this for initialization
	void Start () {
		XForce = 0;
		YForce = 0;
	}
	
	// Update is called once per frame
	void Update () {
		GetInputs();
		MovePlayer();
	}

	private void MovePlayer()
	{
		XForce -= XForce * 0.1f;
		Body.AddForce(new Vector2(XForce, 0));
	}

	private void GetInputs()
	{
		if (Input.GetKey(KeyCode.D))
			XForce += Acceleration * Body.mass * Time.deltaTime;
		if (Input.GetKey(KeyCode.A))
			XForce -= Acceleration * Body.mass * Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
			Body.AddForce(new Vector2(0, JumpAcceleration * Body.mass), ForceMode2D.Impulse);
	}

	private bool IsGrounded()
	{
		return true;
	}
}
