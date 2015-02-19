using UnityEngine;
using System.Collections;
using System.Threading;

public class perso_script : MonoBehaviour {
	public GameObject _perso; //dans prefabs c perso_1
	public Transform _addPerso;//correspond a posperso
	
	public static float xPerso;
	public static float zPerso;
	//position du personnage
	private static GameObject ajouter;
	//permet de mettre le perso dans un objet que l'on peut deplacer
	// Use this for initialization

	void Start () {

		createPerso ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (ray.touch ()) {
		if (enemy_script.verif_enemy(ray.yoloo)) {
				generate_script.terrainCombat();
		}		
		}

	}
	void createPerso(){//on cree notre personnage

		xPerso = 1;
		zPerso = 1;
		_addPerso.transform.position = new Vector3(1,1.5F,1);
		ajouter = (GameObject)Instantiate (_perso,new Vector3(1,1.5F,1), Quaternion.identity);
		ajouter.transform.parent = _addPerso;
		}

	public static bool verif_perso(GameObject objet){//verifie que l'on a toucher le perso
			if (objet == ajouter.gameObject) {
			//Debug.Log("ok");
				return true;
			}
			else {
			//Debug.Log("nok");
			return false;
				}
	}

	}
