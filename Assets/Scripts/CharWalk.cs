using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharWalk : MonoBehaviour
{
    [SerializeField] Rigidbody2D _yamato;
    [SerializeField] BoxCollider2D _yamBox;
    [SerializeField] Animator _yamAnim;
    [SerializeField] Vector2 _move;
    [SerializeField] float _spdMult;
    [SerializeField] float _animHori;
    [SerializeField] float _animVert;
    [SerializeField] float _animMult;

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
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _spdMult = 6;
            _animMult = 2.5f;
            _yamAnim.SetFloat("spdMultiply", _animMult);
        }
        else
        {
            _spdMult = 3;
            _animMult = 1.5f;
            _yamAnim.SetFloat("spdMultiply", _animMult);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _yamato = GetComponent<Rigidbody2D>();
        _yamAnim = GetComponent<Animator>();
        _yamBox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RunToggle();
        Walk();
    }
}
