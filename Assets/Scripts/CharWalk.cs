using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharWalk : MonoBehaviour
{
    [SerializeField] Rigidbody2D _yamato;
    [SerializeField] Animator _yamAnim;
    [SerializeField] Vector2 _move;
    [SerializeField] float _spdMult;
    [SerializeField] float _animHori;
    [SerializeField] float _animVert;
    [SerializeField] float _animMult;
    [SerializeField] bool _faceR;

    void Walk()
    {
        _move.x = Input.GetAxisRaw("Horizontal");
        _move.y = Input.GetAxisRaw("Vertical");
        _yamato.velocity = new Vector2(_move.x * _spdMult, _move.y * _spdMult);
        _animHori = _move.x;
        _animVert = _move.y;
        _yamAnim.SetFloat("horiMov", _animHori);
        _yamAnim.SetFloat("vertMov", _animVert);
    }
    private void RunToggle()
    {
        if (Input.GetKey("left shift"))
        {
            _spdMult = 6;
            _animMult = 2;
            _yamAnim.SetFloat("spdMultiply", _animMult) ;
        }
        else
        {
            _spdMult = 3;
            _animMult = 1;
            _yamAnim.SetFloat("spdMultiply", _animMult);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _yamato = GetComponent<Rigidbody2D>();
        _yamAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RunToggle();
        Walk();
    }
}
