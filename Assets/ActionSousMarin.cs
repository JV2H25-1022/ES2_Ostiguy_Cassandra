using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionSousMarin : MonoBehaviour
{

    [SerializeField] private float vitesseMouvement;

    private Rigidbody _rb;

    private Vector3 directionInput;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue directionBase)
    {
        Vector2 directionAvecVitesse = directionBase.Get<Vector2>() * vitesseMouvement;
        directionInput = new Vector3(directionAvecVitesse.x, 0f, directionAvecVitesse.y);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
