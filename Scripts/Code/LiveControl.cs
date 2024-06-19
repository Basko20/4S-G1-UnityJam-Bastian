using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveControl : MonoBehaviour
{
    public GeneralStorage gs;
    void Update()
    {
        if (CompareTag("live1"))
        {
            if (gs.lives == 0)
            {
                gameObject.SetActive(false);
            }
        }

        if (CompareTag("live2"))
        {
            if (gs.lives < 2)
            {
                gameObject.SetActive(false);
            }
        }

        if (CompareTag("live3"))
        {
            if (gs.lives < 3)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
