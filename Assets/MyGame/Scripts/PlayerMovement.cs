
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 1;

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

    }
}