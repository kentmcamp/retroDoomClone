using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    public AudioSource ammo, enemyDeath, enemyShot, gunShot, playerHurt, health;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayAmmoPickup() {
        ammo.Stop();
        ammo.Play();
    }
    public void PlayEnemyDeath() {
        enemyDeath.Stop();
        enemyDeath.Play();
    }
    public void PlayEnemyShot() {
        enemyShot.Stop();
        enemyShot.Play();
    }
    public void PlayGunshot() {
        // gunShot.Stop();
        gunShot.Play();
    }
    public void PlayAtHealthPickup() {
        health.Stop();
        health.Play();
    }
    public void PlayPlayerHurt() {
        playerHurt.Stop();
        playerHurt.Play();
    }


}
