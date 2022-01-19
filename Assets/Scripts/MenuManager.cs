using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    GameManager gm;
    SoundManager sm;

    [SerializeField] GameObject LanguageMenu;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject InstructionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        sm = FindObjectOfType<SoundManager>();
    }

    public void ChooseLanguage(bool choice)
    {
        gm.ShowJapaneseText(choice);
    }

    public void PlayGame()
    {
        gm.StartGame();
    }

    public void Instructions()
    {
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(true);
    }

    public void NextButton()
    {
        LanguageMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void BackButton()
    {
        InstructionsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        gm.QuitGame();
    }
}
