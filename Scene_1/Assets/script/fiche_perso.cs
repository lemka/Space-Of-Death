using UnityEngine;
using System.Collections;

public class fiche_perso : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static bool fiche()
	{
		if (perso_script.verif_perso(ray.yoloo)) {
			//Debug.Log ("inventaire");
			return true;
				}
		else {
			return false;
				}

	}
}
