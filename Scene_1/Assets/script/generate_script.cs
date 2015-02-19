using UnityEngine;
using System;
using System.Collections;

public class generate_script : MonoBehaviour {
	//variable//
	public Transform[] _stock;//stock les elements generer
	public TextAsset _textMap;//fichier texte
	public GameObject[] _element;//element a placer dans unity
	
	private GameObject ajouter;//c'est le gameobject dans lequelle on stock le new element
	private static GameObject[] _sol = new GameObject[500];//c dedant que je stock chaque gameobject se qui me permet d'avoir tout les renseignements
	private static int length_sol;
	private static GameObject[] _mur = new GameObject[500];//c dedant que je stock chaque gameobject se qui me permet d'avoir tout les renseignements
	private static int length_mur;
	private string text;//on stock dedant tout se qui est ecrit dans le fichier texte
	private float originalx = 0;//position initial de la map en x
	private float originaly = 0;//position initial de la map en y
	private float originalz = 0;//position initial de la map en z
	private float x = 0;//position en x
	private float y = 0;//position en y
	private float z = 0;//position en z
	/// Use this for initialization
	void Start () {
		
		text = _textMap.text;//on ecrit le texte dans la variable
		int j = 0;//permet d'initialiser mon tableau de gameobject du sol
		int h = 0;
		for (int i = 0; i < text.Length; i++) {
			if (text.Substring (i, 1) == "s") {//on  instancie le sol
				ajouter = (GameObject)Instantiate (_element [0], new Vector3 (x, y, z), Quaternion.identity);
				ajouter.transform.parent = _stock [0];
				_sol[j] = ajouter;//on met le gameobject sol dans un tableau pour pouvoir changer sa couleur et tout ...
				j ++;
				x ++;
			} else if (text.Substring (i, 1) == "m") {
				ajouter = (GameObject)Instantiate (_element [1], new Vector3 (x, y, z), Quaternion.identity);
				ajouter.transform.parent = _stock [1];
				h ++;
				x ++;
			} else if (text.Substring (i, 1) == "z") {
				x = originalx;
				z ++;	
			}
		}
		length_sol = j + 1;
		length_mur = h + 1;
	}
	
	public static bool verif_sol(GameObject objet){//verifie que l'on a toucher le sol
		for (int i = 0; i < length_sol; i++) {
			if (objet ==_sol[i]) {
				return true;
			}
		}
		return false;	
	}

	public static bool verif_mur(GameObject objet){//verifie que l'on a toucher le mur
		for (int i = 0; i < length_mur; i++) {
			if (objet ==_mur[i]) {
				return true;
			}
		}
		return false;	
	}
	public static bool verif_objet(GameObject objet, int type, int pos){//verifie que l'on a toucher un objet en particulier
		if (type == 0) {//signifie le sol
			if (objet == _sol[pos]) {
				return true;
			}
		}
		else {
			if (objet == _mur[pos]) {
				return true;
			}
		}
		return false;
	}

	
	public static void changeColor(GameObject objet, Color couleur){//change de couleur la case ou l'on a cliquer
		
		objet.renderer.material.color = couleur;
	}
	// Update is called once per frame
	void Update () {
		
	}

	public static void terrainCombat()
	{
		for (int i = 0; i < length_sol; i++) {
			_sol[i].renderer.material.color = Color.black;
				}

	}
	
	
}


