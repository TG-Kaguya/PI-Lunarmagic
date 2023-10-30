using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Button _btCen;
    public Transform _posDir;

    // Start is called before the first frame update
    public void PortaCen(Transform value)
    {
        value.transform.localPosition = _posDir.position;
    }
}
