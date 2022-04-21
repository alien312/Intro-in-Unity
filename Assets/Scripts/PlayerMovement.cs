using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var xMov = Input.GetAxis("Horizontal");
        var zMov = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(xMov, 0, zMov) * MovementSpeed * Time.deltaTime);
    }
}
