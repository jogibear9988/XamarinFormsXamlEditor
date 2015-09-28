using ICSharpCode.WpfDesign.Extensions;
using XamarinFormsClasses.Base;

namespace ICSharpCode.WpfDesign.Designer.Extensions
{
	[ExtensionServer(typeof(OnlyOneItemSelectedExtensionServer))]
	[ExtensionFor(typeof(VisualElement))]
	public class TopLeftContainerDragHandleXamarin : TopLeftContainerDragHandle
	{
	}	
}
