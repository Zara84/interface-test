using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profilesPanelBehavior : MonoBehaviour {

    public GameObject descriptionPanel;
    public Text title;
    public Text description;
    public Image image;
    public Button button;
    public float alpha = 0.1f;

    public void numbersClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = numbers;
        title.text = "Numbers";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void editNumbersClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = edit;
        title.text = "Edit numbers";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //************************************************

    public void distributionsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = distributions;
        title.text = "Distributions";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void editDistributionsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = edit;
        title.text = "Edit distributions";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //************************************************

    public void corelationsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = corelations;
        title.text = "Correlations";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void editCorelationsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = edit;
        title.text = "Edit correlations";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //************************************************
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //***********************Sprites***************************

    public Sprite numbers;
    public Sprite edit;

    public Sprite distributions;

    public Sprite corelations;
}
