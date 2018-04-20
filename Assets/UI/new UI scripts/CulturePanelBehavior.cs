using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CulturePanelBehavior : MonoBehaviour {

    public GameObject descriptionPanel;
    public Text title;
    public Text description;
    public Image image;
    public Button button;
    public float alpha = 0.1f;

    public void valuesClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = values;
        title.text = "Values";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void individualisticValueMakeupClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = individualistic;
        title.text = "Individualistic value makeup";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void communalValueMakeupClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = communal;
        title.text = "Communal value makeup";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void environmentalValueMakeupClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = environmental;
        title.text = "Environmental value makeup";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void customValueMakeupClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = otherValues;
        title.text = "Custom value makeup";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
    }

    //**********************************************
    public void goalsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = goals;
        title.text = "Goals";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void editGoalsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = edit;
        title.text = "Edit goals";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //***********************************************
    public void normClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = norms;
        title.text = "Norms";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void familyNormsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = familyNorms;
        title.text = "Family related norms";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void communityNormsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = communityNorms;
        title.text = "Community related norms";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void environmetnalNormsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = communityNorms;
        title.text = "Environment related norms";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void workNormsClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = workNorms;
        title.text = "Work related norms";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //**************************************************

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //****************Sprites**********************

    public Sprite values;
    public Sprite individualistic;
    public Sprite communal;
    public Sprite environmental;
    public Sprite otherValues;

    public Sprite goals;
    public Sprite edit;

    public Sprite norms;
    public Sprite familyNorms;
    public Sprite communityNorms;
    public Sprite environmentalNorms;
    public Sprite workNorms;

}
