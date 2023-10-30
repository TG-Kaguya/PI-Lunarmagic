using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port : MonoBehaviour
{

     GameControl _control;
    [SerializeField] Transform _pos;
    // Start is called before the first frame update
    void Start()
    {
        _control = Camera.main.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.gameObject.CompareTag("Player"))
        {
            _control._posDir = _pos;
            _control._btCen.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _control._posDir = null;
            _control._btCen.gameObject.SetActive(false);
        }
    }
}
