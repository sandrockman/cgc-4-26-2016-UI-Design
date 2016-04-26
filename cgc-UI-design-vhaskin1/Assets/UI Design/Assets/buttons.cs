using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

	public Text chatText;


	void Awake ()

	{
        if(chatText != null)
            chatText = chatText.GetComponent<Text> ();
	
	}

public void PlayButton (int scene)
	{

		SceneManager.LoadScene (scene);

	}

public void ExitButton ()

	{

		Application.Quit ();
	}

    public void ToggleButton(bool mainMenu)
    {

        if (mainMenu)
        {
            int move = SceneManager.GetSceneByName("Video5-Toggles").buildIndex;
            SceneManager.LoadScene(move);

        }
    }
    public void _ToggleButtonVideo5(bool mainMenu)
    {

        if (mainMenu)
        {
            SceneManager.LoadScene(2);

        }
    }


    public void ChatInput (InputField chat)
	{

		chatText.text = chat.text;
	}


}
