using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;

namespace ICSharpCode.WpfDesign.Designer.Extensions
{
	[ExtensionServer(typeof(OnlyOneItemSelectedExtensionServer))]
	[ExtensionFor(typeof(VisualElement))]
	public class TopLeftContainerDragHandleXamarin : TopLeftContainerDragHandle
	{
	}	
}
