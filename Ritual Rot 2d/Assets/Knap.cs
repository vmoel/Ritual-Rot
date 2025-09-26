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
    public Text Hovedtext;
    public Button Interknap;

    historien nuværendeBlock;

    static historien block4 = new historien("Men jeg føler mig ikke modig nok lige nu til at ændrer det, måske senere.....", "start");
    static historien block3 = new historien("Altså sådan jeg skal skrive næste hver gang jeg laver en ny dims, hvilket jeg føler nok jeg ikke behøver. Eller okay, jeg ved godt jeg ikke behøver", "næste", block4);
    static historien block2 = new historien("Jeg følger den her tutorial, men sådan ikke rigtigt. Så jeg tror jeg har fucket den lidt op", "næste", block3);
    static historien block1 = new historien("Jeg tester en ny programmerings strat når jeg laver det her!", "næste", block2);



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
