using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButtonScript : MonoBehaviour {

    public GameObject text;
    public GameObject buildPanel;

    public GameObject mainPanel;
    public GameObject secondaryPanel;

    public GameObject secondaryBuildPanel;

    public GameObject policyPanel;
    public GameObject stressorsPanel;
    public GameObject profilesPanel;
    public GameObject culturePanel;
    public GameObject worldPanel;

    public GameObject welcomePanel;
    public GameObject loadScenarioPanel;
    public GameObject infoPanel;

    public GameObject IntroductionPanel;

    public GameObject secondaryDetailsPanel;

    // public GameObject secondaryScenarioPanel;

    public List<GameObject> buildPanels = new List<GameObject>();

	// Use this for initialization
	void Start () {

        buildPanels.Add(secondaryBuildPanel);
        buildPanels.Add(policyPanel);
        buildPanels.Add(stressorsPanel);
        buildPanels.Add(culturePanel);
        buildPanels.Add(profilesPanel);
        buildPanels.Add(worldPanel);
        buildPanels.Add(welcomePanel);
        buildPanels.Add(loadScenarioPanel);
        buildPanels.Add(infoPanel);
        buildPanels.Add(IntroductionPanel);

        welcomePanel.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void turnOffBuildPanels()
    {
        foreach (GameObject g in buildPanels)
        {
            g.SetActive(false);
        }
    }

    public void loadScenario()
    {
        text.SetActive(true);
        text.GetComponent<Text>().text = "Load scenario";
    }

    public void seeDetails()
    {
        text.SetActive(true);
        text.GetComponent<Text>().text = "See details";
    }

    public void buildScenario()
    {
        text.SetActive(true);
        text.GetComponent<Text>().text = "Build scenario";
    }

    public void turnOffText()
    {
        text.SetActive(false);
    }

    public void showBuildMenu()
    {
        turnOffAll();
        buildPanel.SetActive(true);
        mainPanel.SetActive(true);
        secondaryPanel.SetActive(true);
        IntroductionPanel.SetActive(true);
    }

    public void showDetails()
    {
        turnOffAll();
        infoPanel.SetActive(true);
    }

    public void showScenarios()
    {
        turnOffAll();
        loadScenarioPanel.SetActive(true);
    }

    public void turnOffAll()
    {
        buildPanel.SetActive(false);
        mainPanel.SetActive(false);
        secondaryBuildPanel.SetActive(false);
        secondaryPanel.SetActive(false);
        welcomePanel.SetActive(false);
        loadScenarioPanel.SetActive(false);
        infoPanel.SetActive(false);
        IntroductionPanel.SetActive(false);

        worldPanel.SetActive(false);
        policyPanel.SetActive(false);
        culturePanel.SetActive(false);
        profilesPanel.SetActive(false);
        stressorsPanel.SetActive(false);
    }

    public void worldHover()
    {
        setText("World setttings");
    }

    public void worldClick()
    {
        turnOffBuildPanels();
        secondaryBuildPanel.SetActive(true);
    }


    public void policyHover()
    {
        setText("Policy settings");
    }

    public void policyClick()
    {
        turnOffBuildPanels();
        policyPanel.SetActive(true);
    }


    public void profilesHover()
    {
        setText("Profile settings");
    }

    public void profilesClick()
    {
        turnOffBuildPanels();
        profilesPanel.SetActive(true);
    }


    public void cultureHover()
    {
        setText("Culture settings");
    }

    public void cultureClick()
    {
        turnOffBuildPanels();
        culturePanel.SetActive(true);
    }


    public void stressorsHover()
    {
        setText("Stressors settings");
    }

    public void stressorsClick()
    {
        turnOffBuildPanels();
        stressorsPanel.SetActive(true);
    }

    void setText(string t)
    {
        text.SetActive(true);
        text.GetComponent<Text>().text = t;
    }

    public void flareOptions(Button button)
    {
        //Debug.Log(button.name);
        //bool pressed = button.interactable;
        //if (pressed)
        {
            foreach (Transform tr in button.transform)
            {
                if ((tr.gameObject.name != "TipText") && (tr.gameObject.name != "CategoryLabel"))
                {
                    tr.gameObject.SetActive(!tr.gameObject.activeInHierarchy);
                }

                if (tr.gameObject.activeInHierarchy)
                {
                    button.GetComponent<EventTrigger>().enabled = false;
                }
                else
                {
                    button.GetComponent<EventTrigger>().enabled = true;
                }
            }
        }

        /*else
        {
            foreach(Transform tr in button.transform)
            {
                tr.gameObject.SetActive(false);
            }
        }*/

      //  button.interactable = !pressed;
    }

}
