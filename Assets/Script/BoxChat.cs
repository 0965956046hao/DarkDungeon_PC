using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxChat : MonoBehaviour
{
    public static BoxChat instance;
    public GameObject heart;
    public GameObject chat1;
    public GameObject chat2;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        if (PlayerPrefs.HasKey(heart.name))
        {
            if (PlayerPrefs.GetInt(heart.name) == 1)
            {
                chat1.SetActive(true);
                chat2.SetActive(false);
            }
        }
        else
        {
            chat1.SetActive(false);
            chat2.SetActive(true);
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
    public void CloseBoxChat()
    {
        this.gameObject.SetActive(false);
    }
}
