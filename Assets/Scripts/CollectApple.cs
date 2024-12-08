using JetBrains.Annotations;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectApple : MonoBehaviour
{
    public TMP_Text text;
    private int elmaSayisi = 0;
    private void OnTriggerEnter(Collider other)
    {

        
        if(other.CompareTag("Elma"))
        {
            elmaSayisi++;
            Destroy(other.gameObject);
            text.SetText("Elma sayýsý: " + elmaSayisi);
        }
    }
}
