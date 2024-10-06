using UnityEngine;
using UnityEngine.UI;
using static SetText;


public class SetText: MonoBehaviour
{
    public enum Langviges {rus, eng, turk}
    public Langviges langviges;
    [SerializeField] private Language language;

    private void Start()
    {
        Text myText = GetComponent<Text>(); 
        if (langviges == Langviges.rus)
        {
            myText.text = language.ru;
        }
        else
        {
            if (langviges == Langviges.eng) 
            {
                myText.text = language.en;
            }
            if (langviges == Langviges.turk)
            {
                myText.text = language.tr;
            }
            
        }
    }
}
