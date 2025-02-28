using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionSousMarin : MonoBehaviour
{

    [SerializeField] private float vitesseMouvement;

    

    private Rigidbody _rb;

    private Vector3 directionInput;

    public InputActionReference move;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        vitesseMouvement = 1;
        animator = GetComponent<Animator>();
    }


    void OnAccelerer(InputValue etatBouton)
     {
         if(etatBouton.isPressed) {
            vitesseMouvement = 2;
       }
         else{
             vitesseMouvement = 1;
         }
     }
    // Update is called once per frame

    
    private void Update()
     {
        directionInput = move.action.ReadValue<Vector3>();
       
     }
    private void FixedUpdate()
    {
        //Vector3 mouvement = directionInput;
        _rb.velocity = new Vector3(directionInput.x * vitesseMouvement, directionInput.y * vitesseMouvement, directionInput.z * vitesseMouvement);

    }

   



 }