using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class gesture : MonoBehaviour {
    GestureRecognizer recognizer;

	void Start () {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.Tapped += Recognizer_Tapped;
        recognizer.StartCapturingGestures();
	}

    private void Recognizer_Tapped(TappedEventArgs obj)
    {
        if (gaze.Instance.GazedObject != null)
        {
            cube cube = gaze.Instance.GazedObject.GetComponent<cube>();
            if (cube != null)
                cube.Rotate = !cube.Rotate;
        }
    }

    void Update () {
		
	}

    private void OnDestroy()
    {
        recognizer.Tapped -= Recognizer_Tapped;
        recognizer.StopCapturingGestures();
    }
}
