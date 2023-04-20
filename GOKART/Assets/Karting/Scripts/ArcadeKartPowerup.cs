using KartGame.KartSystems;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ArcadeKartPowerup : MonoBehaviour {

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };

    public bool isCoolingDown { get; private set; }
    public float lastActivatedTimestamp { get; private set; }

    public float cooldown = 5f;

    public bool disableGameObjectWhenActivated;
    public UnityEvent onPowerupActivated;
    public UnityEvent onPowerupFinishCooldown;

    private void Awake()
    {
        lastActivatedTimestamp = -9999f;
    }





    private void OnTriggerEnter(Collider other)
    {
        

        var rb = other.attachedRigidbody;
        if (rb) {

            var kart = rb.GetComponent<ArcadeKart>();

            if (kart)
            {
                if (boostStats.ElapsedTime != 0)
                {
                    boostStats.ElapsedTime = 0;
                }
                lastActivatedTimestamp = Time.time;
                kart.AddPowerup(this.boostStats);
                onPowerupActivated.Invoke();
                isCoolingDown = true;
            }
        }
               
    }



  

}
