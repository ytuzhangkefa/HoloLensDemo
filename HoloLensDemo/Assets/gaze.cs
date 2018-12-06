using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaze : MonoBehaviour {

    public static gaze Instance;

	void Start () {
        if (Instance == null)
            Instance = this;
	}

    private GameObject gazedObject;

    /// <summary>
    /// 当前凝视的GameObject
    /// </summary>
    public GameObject GazedObject
    {
        get {
            return gazedObject;
        }
    }
	
	void Update () {

        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if (Physics.Raycast(origin, direction, out hitInfo, 20, Physics.DefaultRaycastLayers))
        {
            this.gazedObject = hitInfo.transform.gameObject;
        }
        else
        {
            this.gazedObject = null;
        }
	}
}
