using UnityEngine;
using TMPro;

public class PasswordButton : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;
    public int number;

    private void Start()
    {
        number = 0;
        numberText.text = number.ToString();
    }

    public void OnClickThis()
    {
        number++;
        if (number > 9)
        {
            number = 0;
        }
        numberText.text = number.ToString();
    }
}
