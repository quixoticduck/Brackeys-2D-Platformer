using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

//	public PlayerController player;

	public bool isActive;
	
	// Use this for initialization
	void Start () 
	{
//		player = FindObjectOfType<PlayerController>();

		if(textFile != null)
			
		{
			// \n represents a line break (whenever our text file has an enter pressed)
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0)
		{
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			EnabletextBox();
		}

		else {
			DisabletextBox();
		}

	}


	void Update()
	{
		if (!isActive)
		{
			return;
		}

		theText.text = textLines[currentLine];

		if(Input.GetKeyDown(KeyCode.Return))
		{
			currentLine +=1;
		}


		if(currentLine > endAtLine) 
		{
			DisabletextBox();
		}

	}

	public void EnabletextBox()
	{
		textBox.SetActive(true);
	}

	public void DisabletextBox()
	{
		textBox.SetActive(false);
	}
}