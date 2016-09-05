using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rightFoot, leftFoot;

    [SerializeField]
    private Rigidbody rightArm, leftArm;

    [SerializeField]
    private float force,  armAttack;

    [SerializeField]
    private Vector3 movementVector;

	private void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.W))
        {
            rightFoot.AddRelativeForce(movementVector * force, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            leftFoot.AddRelativeForce(movementVector * force, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rightFoot.AddForce(-movementVector * force, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            leftFoot.AddForce(-movementVector * force, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Vector3 attack = Vector3.forward * Random.value;
            leftArm.AddRelativeForce(attack * armAttack, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Vector3 attack = Vector3.forward * Random.value;
            rightArm.AddRelativeForce(attack * armAttack, ForceMode.Impulse);
        }
    }
}
