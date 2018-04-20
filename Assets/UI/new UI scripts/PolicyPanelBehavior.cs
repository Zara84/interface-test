using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolicyPanelBehavior : MonoBehaviour {

    public GameObject descriptionPanel;
    public Text title;
    public Text description;
    public Image image;
    public Button button;
    public float alpha = 0.1f;

    public void quotaClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = quota;
        title.text = "Quota";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void icelandicITQClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = icelandicITQ;
        title.text = "Icelandic ITQ";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void vesselQuotaClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = vesselQuota;
        title.text = "Vessel quota";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void genericITQClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = genericITQ;
        title.text = "Generic ITQ";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //*********************************************************

    public void effortClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = effort;
        title.text = "Effort";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void faroeseEffortClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = faroeseEffort;
        title.text = "Faroese effort";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void genericEffortClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = genericEffort;
        title.text = "Generic effort";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    //**********************************************************

    public void otherClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = other;
        title.text = "Other";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void commonsPolicyClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = commonsPolicy;
        title.text = "Commons";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }

    public void auctionPolicyClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = auctionPolicy;
        title.text = "Auction";
        description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";

    }
    //**********************************

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //******************Sprites

    public Sprite quota;
    public Sprite icelandicITQ;
    public Sprite vesselQuota;
    public Sprite genericITQ;

    public Sprite effort;
    public Sprite faroeseEffort;
    public Sprite genericEffort;

    public Sprite other;
    public Sprite commonsPolicy;
    public Sprite auctionPolicy;
}
