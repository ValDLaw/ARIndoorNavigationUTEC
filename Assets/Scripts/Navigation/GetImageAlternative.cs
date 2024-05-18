using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GetImageAlternative : MonoBehaviour
{
    [SerializeField]
    private ARTrackedImageManager trackedImageManager;
    [SerializeField]
    private TextMeshProUGUI imageText;

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            UpdateImageText(trackedImage);
        }

        foreach (var trackedImage in eventArgs.updated)
        {
            UpdateImageText(trackedImage);
        }
    }

    private void UpdateImageText(ARTrackedImage trackedImage)
    {
        if (trackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
        {
            imageText.text = trackedImage.referenceImage.name;
        }
    }
}
