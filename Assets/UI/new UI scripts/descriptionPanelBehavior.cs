using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class descriptionPanelBehavior : MonoBehaviour {

    public GameObject descriptionPanel;
    public Text title;
    public Text description;
    public Image image;
    public Button button;
    public float alpha = 0.1f;

    public void terrainClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(false);
        image.sprite = terrain;
        title.text = "Terrain";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select your terrain. If you're not modelling a specific context, we recommend using a generic or flat terrain, which may be less misleading to your audience when presenting your model.";
    }

    public void icelandClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);
        button.gameObject.SetActive(true);
        image.sprite = iceland;
        title.text = "Iceland";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select this terrain if your model concerns the Icelandic context. Be advised that none of the other components are automatically set to values derived from Icelandic data.";
    }

    public void generalClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = generalterrain;
        title.text = "Generic";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select this terrain if your model doesn't concern any particular real world context, or is a generalized version of one or more real world contexts.";
    }

    public void flatClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = flat;
        title.text = "Flat";
        // description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select this terrain if your model doesn't concern any particular real world context, or is a generalized version of one or more real world contexts.";

    }

    //********************************************************

    public void resourceClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        descriptionPanel.SetActive(true);
        button.gameObject.SetActive(false);
        image.sprite = resource;
        title.text = "Resource";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select the resources you want in your model. You can select more than one, but you need to parameterize all of them on a case by case basis.";
    }

    public void pelagicClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = pelagic;
        title.text = "Pelagic";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your pelagic resource. If you're modelling a generic fish resource, add only one type of resource and parameterize as needed.";
    }

    public void demersalClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = demersal;
        title.text = "Demersal";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your de demersal resource. If you're modelling a generic fish resource, add only one type of resource and parameterize as needed.";
    }

    public void crustaceansClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = crustaceans;
        title.text = "Crustaceans";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your crustacean resource. If you're modelling a generic fish resource, add only one type of resource and parameterize as needed.";
    }

    // ***********************************************

    public void communityClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        descriptionPanel.SetActive(true);
        button.gameObject.SetActive(false);
        image.sprite = community;
        title.text = "Communities";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select the types of community you want in your model. You can select more than one, but you ned to parameterize all of them on a case by case basis. We don't recommend selecting more than three types. ";
    }

    public void strongFishingComClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = strongFishingCom;
        title.text = "Strong fishing community";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your strong fishing community. Typically, a strong fishing community relies heavily on its fishing industry and/or handles a significant portion of the fishing industry's total activity.";
    }

    public void fishingComClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = fishingCom;
        title.text = "Fishing community";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your fishing community. Tipically, a fishing community relies on its fishing industry, but this should not be the only significant economic engine it has.";
    }

    public void minimalFishingComClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = minimalFishingCom;
        title.text = "Minimal fishing community";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your minimal fishing community. Typically, a minimal fishing community handles some of the fishing industry's total activity, but it does not rely localy on fishing.";
    }

    public void mixedComClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = mixedCom;
        title.text = "Mixed fishing community";
        // description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your mixed community. Typically, a mixed community relies equally on fishing and one or more other industries or economic engines.";
    }

    public void seasonalComClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = seasonalCom;
        title.text = "Seasonal fishing community";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your seasonal fishing community. Typically, seasonal fishing communities rely on fishing activities only part of the year, and the rest of the year rely on other industries or become dormant.";
    }

    public void urbanComClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = urbanCom;
        title.text = "Urban community";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your urban community. Typically, urban communities are hubs of economic activity and large concentration of population. They tend to be more attractive as places to live, study and work than rural communities and offer a larger selection of services. They may or may not participate in fishing activities.";
    }

    //****************************************************

    public void fleetClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        descriptionPanel.SetActive(true);
        button.gameObject.SetActive(false);
        image.sprite = boat;
        title.text = "Fleet";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Select the types of boats you want in your fleet. You can select more then one, but you need to parameterize each one on a case by case basis.";
    }

    public void smallBoatClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = smallBoat;
        title.text = "Small boat";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your small boats. They can be anything from relatively high tech, high efficiency boats to traditional boats that have remained more or less unchanged for hundred of years.";
    }

    public void trawlerBoatClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = trawlerBoat;
        title.text = "Trawler";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your trawlers.";
    }

    public void lineBoatClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = lineBoat;
        title.text = "Line boat";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your line boats. ";
    }

    public void seineBoatClick()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<Image>().color = new Color(descriptionPanel.GetComponent<Image>().color.r, descriptionPanel.GetComponent<Image>().color.g, descriptionPanel.GetComponent<Image>().color.b, alpha);

        button.gameObject.SetActive(true);
        image.sprite = seineBoat;
        title.text = "Seine boat";
        //description.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam non arcu nec diam dignissim aliquam. Fusce vel sem eu odio finibus posuere vel at nulla. Vestibulum porta enim ex, malesuada fringilla orci efficitur eu. Nullam vel ipsum ipsum. Suspendisse eu enim ut massa tristique malesuada. Etiam ac ligula consectetur, aliquet libero sit amet, venenatis nisl. Ut hendrerit, urna in lobortis iaculis, risus urna cursus mi, id tempus massa nulla ac felis. ";
        description.text = "Parameterize your seine boats.";
    }
    //*********************************************************


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Sprite terrain;
    public Sprite iceland;
    public Sprite generalterrain;
    public Sprite flat;

    public Sprite resource;
    public Sprite pelagic;
    public Sprite demersal;
    public Sprite crustaceans;

    public Sprite community;
    public Sprite strongFishingCom;
    public Sprite fishingCom;
    public Sprite minimalFishingCom;
    public Sprite mixedCom;
    public Sprite seasonalCom;
    public Sprite urbanCom;

    public Sprite boat;
    public Sprite smallBoat;
    public Sprite trawlerBoat;
    public Sprite seineBoat;
    public Sprite lineBoat;
}
