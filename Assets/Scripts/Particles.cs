using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public GameObject triggerParticle;
    public GameObject collisionParticle;

    //Get executed when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle  = null)
        {
            //The triggerParticle will be spawned at the location of this object
            //with the same rotaion as the object
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
    }

    //Get executed when something collides with this object
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle is null)
        {
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
