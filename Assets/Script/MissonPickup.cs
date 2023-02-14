using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissonPickup : MonoBehaviour
{
    public float waitToColected = .5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waitToColected > 0)
        {
            waitToColected -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player" && waitToColected <= 0 && other.GetComponent<PlayerController>().view.IsMine)
        {
            PlayerPrefs.SetInt("Heart", 1);
            AudioManager.instance.PlaySFX(7);
            Destroy(gameObject);
        }
    }
}
