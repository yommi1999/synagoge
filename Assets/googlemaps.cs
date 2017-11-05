using UnityEngine;
using System.Collections;

public class googlemaps: MonoBehaviour {

	public string pageToOpen = "https://www.google.com/maps/d/viewer?mid=105rOU1HDlmvLVb8sLAVcJ3-7SII&II=52.66232368194429%2C6.7391739176950000001&z=17";

	// check readme file to find out how to change title, colors etc.
	public void Onactivated() {
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = "InAppBrowser example";

		InAppBrowser.OpenURL(pageToOpen, options);
	}

	public void OnClearCacheClicked() {
		InAppBrowser.ClearCache();
	}
}