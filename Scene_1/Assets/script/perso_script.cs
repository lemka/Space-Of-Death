using UnityEngine;
using System.Collections;
using System.Threading;

public class perso_script : MonoBehaviour {
	public GameObject _perso; //dans prefabs c personnage
	public Transform _addPerso;//correspond a posperso

	private float xOrigin;
	private float zOrigin;
	private float x;
	private float z;
	//position du personnage
	private GameObject ajouter;
	//permet de mettre le perso dans un objet que l'on peut deplacer
	private int create = 0;
	// Use this for initialization

	void Start () {

		createPerso ();
	
	}
	
	// Update is called once per frame
	void Update () {
		deplacePerso ();
	
	}
	void createPerso(){

		_addPerso.transform.position = new Vector3(1,1.5F,1);
		ajouter = (GameObject)Instantiate (_perso,new Vector3(1,1.5F,1), Quaternion.identity);
		ajouter.transform.parent = _addPerso;
		xOrigin = 1.0F;
		zOrigin = 1.0F;

		}
	void deplacePerso()
	{
				if (Input.GetMouseButtonDown (0) && create == 0) {
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						//ray = lance un fil, camer...=origine , inpu...=point ou on le lance
						RaycastHit hit;
						//cree pour donner un game object dedant
						if (Physics.Raycast (ray, out hit) && hit.point.x < 6.5 && hit.point.x > 0.5 && hit.point.z < 6.5 && hit.point.z > 0.5) {
								//physics...=verifie si l'on touche un objet // hit point correspond a la taille de la map
								
								/*_addPerso.transform.position = hit.point;
								ajouter = (GameObject)Instantiate (_perso, hit.point, Quaternion.identity);
								ajouter.transform.parent = _addPerso;
								Debug.Log (hit.point);*/
								
								//permet de se deplacer a la position precise toucher par le ray

				var yolo = Physics.OverlapSphere(hit.point, 0);//chope le gameobject toucher par le ray

				generate_script.changeColor(yolo[0].gameObject, Color.black);
				x = yolo[0].transform.position.x;
				z = yolo[0].transform.position.z;

				_addPerso.transform.position = new Vector3(x, 1, z);
				generate_script.verif(yolo[0].gameObject);
				//_addPerso.rigidbody.AddForce ( new Vector3(x, 1, z)*Time.deltaTime);
				//ajouter = (GameObject)Instantiate (_perso, new Vector3(x, 1, z), Quaternion.identity);//cree un nouvel objet
				//ajouter.transform.parent = _addPerso;
				//Debug.Log(yolo[0].transform.position);
				// a mettre dans le main au dessus on suppose que c le sol qui a ete toucher

		
						}
				}
		}
	}
