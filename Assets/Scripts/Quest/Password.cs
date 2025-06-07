using UnityEngine;

public class Password : MonoBehaviour
{
    [SerializeField] int[] correctNumbers;
    [SerializeField] PasswordButton[] passwordButtons;

    public void CheckCorrect()
    {
        if (isCorrect())
        {
            Debug.Log("�н����� ��ġ");
        }
    }
    bool isCorrect()
    {
        for(int i=0; i<correctNumbers.Length; i++)
        {
            if (passwordButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }

        return true;
    }
}
