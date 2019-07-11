using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using PJ;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(EventSystem.current.IsPointerOverGameObject());

        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, raycastResults);
        foreach (RaycastResult raycastResult in raycastResults) {
            if (raycastResult.gameObject.GetComponentInParent<CardVisualization>() != null) {
                Debug.Log("hit");
            }
        }
	}
}
