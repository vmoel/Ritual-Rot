using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

class historien
{
    public string skriften;
    public string næste;
    public historien næsteknapBlock;

    public historien(string skriften = "", string næste = "", historien næsteknapBlock = null)
    {
        this.skriften = skriften;
        this.næste = næste;
        this.næsteknapBlock = næsteknapBlock;
    }

}
public class Knap : MonoBehaviour
{
    public Button begynd;
    public Text Hovedtext;
    public Button Interknap;

    historien nuværendeBlock;
    static historien block6 = new historien("Og du, er nu en af de få der er tilbage.", "", null);
    static historien block5 = new historien("Pavens riddere slagtede næsten alle zombierne.", "næste", block6);
    static historien block4 = new historien("Huse gik i brand med skrig og sorg imens deres naboer låste dørene.", "næste", block5);
    static historien block3 = new historien("Zombierne som havde erklæret sig selv som selvstændig fra byens regler og love, i håb om frihed, blev jaget og dræbt.", "næste", block4);
    static historien block2 = new historien("Tidligere var byen opdelt i religiøse, zombier, og alt imellem, men efter korstoget ændrede dynamikken sig.", "næste", block3);
    static historien block1 = new historien("Velkommen til verden Kestria, du befinder dig på kanten af landets hovedstad ny Ethania.", "næste", block2);



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        begynd.gameObject.SetActive(false);
        HvisBlock(block1);
    }

    void HvisBlock(historien block)
    {
        Hovedtext.text = block.skriften;
        Interknap.GetComponentInChildren<Text>().text = block.næste;
        nuværendeBlock = block;

        if (nuværendeBlock == block6)
        {
            Destroy(Interknap);
            begynd.gameObject.SetActive(true);
        }
    }

    public void berørtknap()
    {
        HvisBlock(nuværendeBlock.næsteknapBlock);
    }
    


}
