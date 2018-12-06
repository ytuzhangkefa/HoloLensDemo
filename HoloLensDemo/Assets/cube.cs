using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

    bool rotate = false;

	void Start () {
		
	}
	
	void Update () {
        if(rotate)
            transform.Rotate(Vector3.up);
	}

    public bool Rotate
    {
        set {
            this.rotate = value;
        }

        get {
            return this.rotate;
        }
    }
}
