using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour 
{
	public GameObject Target;


	void Start()
	{
		Target = GameObject.FindGameObjectWithTag("Player");
		Quaternion rotation = Quaternion.LookRotation(Target.transform.position - transform.position, transform.TransformDirection(Vector3.up));
		transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

		rigidbody2D.AddForce(-transform.right * 5000);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy (other.gameObject);
			Application.LoadLevel(1);
			return;
		}

	}




}
