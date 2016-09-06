using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rightFoot, leftFoot;

    [SerializeField]
    private Rigidbody rightArm, leftArm, body;

    [SerializeField]
    private float force, armAttack;

    [SerializeField]
    private Vector3 movementVector, bodyTorque;

    private bool wasLastLegRight = false;

	private void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.W))
        {
            float direction = Input.GetAxis("Horizontal");
            Vector3 legForce = movementVector * force;

            if (wasLastLegRight)
            {
                leftFoot.AddRelativeForce(legForce, ForceMode.Impulse);
            }
            else
            {
                rightFoot.AddRelativeForce(legForce, ForceMode.Impulse);
            }
            wasLastLegRight = !wasLastLegRight;
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.transform.eulerAngles -= bodyTorque;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            body.transform.eulerAngles += bodyTorque;
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
