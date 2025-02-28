using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionSousMarin : MonoBehaviour
{

    [SerializeField] private float _vitesseMouvement;

    

    private Rigidbody _rb;

    private Vector3 _directionInput;

    public InputActionReference move;

    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _vitesseMouvement = 1;
        _animator = GetComponent<Animator>();
    }


    void OnAccelerer(InputValue etatBouton)
     {
         if(etatBouton.isPressed) {
            _vitesseMouvement = 2;
       }
         else{
             _vitesseMouvement = 1;
         }
     }
    // Update is called once per frame

    
    private void Update()
     {
        _directionInput = move.action.ReadValue<Vector3>();



        //Vertical
        if (_directionInput.y > 0){
            _animator.SetBool("MvtVertical", true);
        }
        else if (_directionInput.y < 0)
        {
            _animator.SetBool("MvtVertical", true);
        }
        else
        {
            _animator.SetBool("MvtVertical", false);
        }

        //Horizontal
        if (_directionInput.z > 0)
        {
            _animator.SetBool("MvtHorizontal", true);
        }
        else if (_directionInput.z < 0)
        {
            _animator.SetBool("MvtHorizontal", true);
        }
        else
        {
            _animator.SetBool("MvtHorizontal", false);
        }
    }
    private void FixedUpdate()
    {
        
        _rb.velocity = new Vector3(_directionInput.x * _vitesseMouvement, _directionInput.y * _vitesseMouvement, _directionInput.z * _vitesseMouvement);

    }

   



 }