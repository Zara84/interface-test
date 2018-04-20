using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tooltipBehavior : MonoBehaviour {

    public Text hiddenText;
    public Text shownText;
    public Image tip;
    public Image body;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void show(Button button)
    {
        hiddenText.text = button.GetComponentInChildren<Text>().text + "\n";
        shownText.text = button.GetComponentInChildren<Text>().text;

        // Vector2 centerButton = button.GetComponent<RectTransform>().position;
        //Vector2 centerTip = gameObject.GetComponent<RectTransform>().position;

        //  hiddenText.GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        //   gameObject.transform.SetPositionAndRotation(new Vector3(button.transform.position.x, button.transform.position.y + 75 + body.GetComponent<RectTransform>().rect.height / 2, 0), Quaternion.identity);

        StartCoroutine(resize(button));

    }

    public void showChild(Button button)
    {
        hiddenText.text = button.GetComponentInChildren<Text>().text + "\n";
        shownText.text = button.GetComponentInChildren<Text>().text;

        // Vector2 centerButton = button.GetComponent<RectTransform>().position;
        //Vector2 centerTip = gameObject.GetComponent<RectTransform>().position;

        //  hiddenText.GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        //   gameObject.transform.SetPositionAndRotation(new Vector3(button.transform.position.x, button.transform.position.y + 75 + body.GetComponent<RectTransform>().rect.height / 2, 0), Quaternion.identity);

        StartCoroutine(resize(button));

    }

    IEnumerator resize(Button button)
    {
        for (int i=0; i<2; i++)
        {
            gameObject.transform.SetPositionAndRotation(new Vector3(button.transform.position.x, button.transform.position.y + 50 + body.GetComponent<RectTransform>().rect.height / 2, 0), Quaternion.identity);
           // Debug.Log(button.transform.position.x);
            // gameObject.transform.SetPositionAndRotation(new Vector3(x, y + 75 + displacement, 0), Quaternion.identity);
            yield return null;
        }
    }

    public void hide()
    {
        gameObject.transform.SetPositionAndRotation(new Vector3(-100, -100, 0), Quaternion.identity);
    }
}
