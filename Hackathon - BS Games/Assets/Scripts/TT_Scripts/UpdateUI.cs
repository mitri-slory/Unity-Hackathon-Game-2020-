using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class UpdateUI : MonoBehaviour {

	[SerializeField]
	private TextMeshProUGUI timerLabel;

    [SerializeField]
    private TextMeshProUGUI cubesLabel;

	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.TimeRemaining > 0)
		{
			timerLabel.text = FormatTime(GameManager.Instance.TimeRemaining);
		}
		else
		{

			timerLabel.text = "LAVA IS COMING! ESCAPE!";
		}
        cubesLabel.text = GameManager.Instance.NumCubes.ToString();
	}

	private string FormatTime(float timeInSeconds)
	{
		return string.Format("{0}:{1:00}", Mathf.FloorToInt(timeInSeconds/60), Mathf.FloorToInt(timeInSeconds % 60));
	}
}
