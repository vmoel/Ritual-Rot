using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Ending2 : MonoBehaviour
{
    public Text Hovedtext;
    public Button Interknap;

    historien nuværendeBlock;

    static historien block4 = new historien("The end", "", null);
    static historien block3 = new historien("Alt ved kulten er uapallerende i dine øjne", "næste", block4);
    static historien block2 = new historien("Nummer 1 kult HADER", "næste", block3);
    static historien block1 = new historien("Du gik imod kulten!", "næste", block2);



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HvisBlock(block1);
    }

    void HvisBlock(historien block)
    {
        Hovedtext.text = block.skriften;
        Interknap.GetComponentInChildren<Text>().text = block.næste;

        nuværendeBlock = block;
    }

    public void berørtknap()
    {
        HvisBlock(nuværendeBlock.næsteknapBlock);
    }
}

