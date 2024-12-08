using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IDKWhatImDoin : MonoBehaviour
{
    public TMP_Text text2;
    private int hp = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sepet"))
        {
            hp++;
            Destroy(other.gameObject);
            Instantiate(other.gameObject, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)), Quaternion.identity);
            text2.text ="HP: " + hp;
        }
        else if (other.CompareTag("Yer"))
        {   
            hp--;
            Destroy(this.gameObject);
            text2.SetText("HP: " + hp);
        }
    }
}
