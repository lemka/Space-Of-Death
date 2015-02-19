using UnityEngine;
using System.Collections;

public class enemy_script : MonoBehaviour {
	public GameObject _enemy;//objet enemy
	public Transform _stock_enemy;//stock l'enemy
	private static GameObject ajouter;

	public static int xEnemy;
	public static int zEnemy;
	// Use this for initialization
	void Start () {
		Vector3 posEnemey = new Vector3 (Random.Range (2, 22), 1.5F, Random.Range (2, 13));
		ajouter = (GameObject)Instantiate (_enemy, posEnemey, Quaternion.identity);
		ajouter.transform.parent = _stock_enemy;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static bool verif_enemy(GameObject objet){//verifie que l'on a toucher le perso
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
