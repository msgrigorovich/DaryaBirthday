using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogReward : MonoBehaviour
{
    public GameObject panelReward;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            panelReward.SetActive(true);
            /*Time.timeScale = 0;*/
        }
    }
}