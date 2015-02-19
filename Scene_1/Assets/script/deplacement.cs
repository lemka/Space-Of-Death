using UnityEngine;
using System.Collections;

public class deplacement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static bool deplacePerso(Transform _addPerso)
	{
				if (generate_script.verif_sol(ray.yoloo)) {//verifie si c le sol que l'on a toucher
				
					perso_script.xPerso = ray.yoloo.transform.position.x;
					perso_script.zPerso = ray.yoloo.transform.position.z;
					Vector3 vecteurPerso =new Vector3(perso_script.xPerso, 1, perso_script.zPerso) - _addPerso.transform.position;
					//utile pour le transform.translate
					//_addPerso.transform.position = new Vector3(x, 1, z);//deplace instantanement
					
					_addPerso.transform.Translate(vecteurPerso);//deplace avec translate
					generate_script.changeColor(ray.yoloo, Color.green);
					return true;
				}
				else{
					//Debug.Log("c pas le sol");
					return false;
				}
		}

	}
