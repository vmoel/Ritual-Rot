using System.Collections;
using System.Data;
using Unity.Multiplayer.Center.Common.Analytics;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;


public class interaktion : MonoBehaviour
{
    public GameObject DialogPanel;
    public Text DialogText;
    public string[] dialog;
    private int index;

    public GameObject næstek;

    public float ordHastighed;

    public bool Nærspiller;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Nærspiller)
        {
            if (DialogPanel.activeInHierarchy)
            {
                ingenT();

            }
            else
            {
                DialogPanel.SetActive(true);
                StartCoroutine(skriver());
            }
        }

        if (DialogText.text == dialog[index])
        {
            næstek.SetActive(true);
        }
    }

    public void ingenT()
    {
        DialogText.text = "";
        index = 0;
        DialogPanel.SetActive(false);
    }
    IEnumerator skriver()
    {
        foreach (char letter in dialog[index].ToCharArray())
        {
            DialogText.text += letter;
            yield return new WaitForSeconds(ordHastighed);
        }
    }

    public void NæsteLinje()
    {
        næstek.SetActive(false);
        if (index < dialog.Length - 1)
        {
            index++;
            DialogText.text = "";
            StartCoroutine(skriver());
        }
        else
        {
            ingenT();
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Nærspiller = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Nærspiller = false;
            ingenT();
        }
    }

}
