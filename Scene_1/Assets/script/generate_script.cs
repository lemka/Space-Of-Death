using UnityEngine;
using System;
using System.Collections;

public class generate_script : MonoBehaviour {
	public Transform[] _stock;//stock les elements generer
	public TextAsset _textMap;//fichier texte
	public GameObject[] _element;//element a placer dans unity


	private GameObject ajouter;

	private static GameObject[] _sol = new GameObject[100];
	private string text;
	private float originalx;
	private float originaly;
	private float originalz;
	private float x = 0;
	private float y = 0;
	private float z = 0;
	/// Use this for initialization
	void Start () {
				originalx = x;
				originaly = y;
				originalz = z;
				text = _textMap.text;
	
	
				for (int i = 0; i < text.Length; i++) {
			int j = 0;
						if (text.Substring (i, 1) == "s") {
								ajouter = (GameObject)Instantiate (_element [0], new Vector3 (x, y, z), Quaternion.identity);
								//Debug.Log(tabPos[i][0]);
								ajouter.transform.parent = _stock [0];
								x = x + 1;
				_sol[j] = ajouter;//on met le gameobject sol dans un tableau pour pouvoir changer sa couleur et tout ...
				j = j+1;
				//Debug.Log(_sol[i]);
						} else if (text.Substring (i, 1) == "m") {
								ajouter = (GameObject)Instantiate (_element [1], new Vector3 (x, y, z), Quaternion.identity);
								ajouter.transform.parent = _stock [1];
								x = x + 1;
						} else if (text.Substring (i, 1) == "z") {
								x = originalx;
								z = z + 1;	
						}
				}
		}
	public static void changeColor(GameObject objet, Color couleur){//change de couleur la case ou l'on a cliquer

		if (objet.renderer.material.color == couleur) {
			objet.renderer.material.color = Color.white;
				}
		else {
			objet.renderer.material.color = couleur;
				}
	}
	public static void verif(GameObject objet){// test pour plus tard savoir si l'objet toucher est celui rechercher
		if (objet==_sol[0]) {
			Debug.Log("ca marche");

				}

		}
	// Update is called once per frame
	void Update () {
				//if (Input.GetMouseButtonDown(0)) {
				//	x=tabPos[13][0];
				//	y=1;
				//	z=tabPos[13][2];

				//	GameObject ajouter = (GameObject)Instantiate(_element[2],new Vector3(x,y,z) , Quaternion.identity);
				
		}
		 
	
	}


