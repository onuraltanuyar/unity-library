using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {

	public Transform Gun;
	public Transform Player;

	void Update() {
		Vector3 fwd = Player.transform.TransformDirection(Vector3.forward);
		if(Input.GetButtonDown("Fire1"))
		{ 
			Gun.GetComponent<Animation>().Play("ShootANIM");
			if (Physics.Raycast(Player.transform.position, fwd, 10))
			{
				return 1;
			}
		}
	}
}
