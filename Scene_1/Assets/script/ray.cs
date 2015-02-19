using UnityEngine;
using System.Collections;

public class ray : MonoBehaviour {
	public static GameObject yoloo;// c le gameobject qui a ete toucher
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static bool touch()//verifie si on a toucher qqchose
	{
		if (Input.GetMouseButtonDown (0)) {
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						//ray = lance un fil, camer...=origine , inpu...=point ou on le lance
						RaycastHit hit;
						//cree pour donner un game object dedant
			
						if (Physics.Raycast (ray, out hit)) {
								//physics...=verifie si l'on touche un objet // hit point correspond a la taille de la map
								var yolo = Physics.OverlapSphere (hit.point, 0);//chope le gameobject toucher par le ray
				yoloo = yolo[0].gameObject;//on stock le gameobject toucher dans yoloo pour l'avoir dans les autres scripts
				return true;				
						} 
						else {
							return false;		
						}
				}
			else {
			return false;
			}
		
	}

}

