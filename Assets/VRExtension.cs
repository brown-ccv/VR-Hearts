
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRExtension : XRGrabInteractable
{
    private Quaternion interactorRotation = Quaternion.identity;
    private Quaternion old_rotation = Quaternion.identity;
    // Start is called before the first frame update
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        bool isDirect = args.interactor is XRDirectInteractor;
        attachTransform.position = args.interactor.attachTransform.position;
        attachTransform.rotation = args.interactor.attachTransform.rotation;
    }


}
