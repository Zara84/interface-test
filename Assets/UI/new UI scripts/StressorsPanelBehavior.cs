using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressorsPanelBehavior : MonoBehaviour {

    public GameObject descriptionPanel;
    public Text title;
    public Text description;
    public Image image;
    public Button button;
    public float alpha = 0.1f;

    public void resourceStressorClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = resource;
        title.text = "Resource stressors";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void missingStocksClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = missingStocks;
        title.text = "Missing stocks";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void deadStocksClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = deadStocks;
        title.text = "Dead stocks";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void otherResourceStressorClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = otherResourceStressor;
        title.text = "Other resoure stressor";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //****************************************
    public void economicClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = economic;
        title.text = "Economic stressors";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void marketCrashClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = marketCrash;
        title.text = "Market crash";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void otherEconomicStressorClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = otherEconomicStressor;
        title.text = "Other economic stressor";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //***************************************

    public void socialClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = social;
        title.text = "Social stressors";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void policyChangeClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = policyChange;
        title.text = "Policy change";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void normChangeClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = normChange;
        title.text = "Norm change";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //******************************************

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //****************Sprites****************

    public Sprite resource;
    public Sprite missingStocks;
    public Sprite deadStocks;
    public Sprite otherResourceStressor;

    public Sprite economic;
    public Sprite marketCrash;
    public Sprite otherEconomicStressor;

    public Sprite social;
    public Sprite policyChange;
    public Sprite normChange;
}
