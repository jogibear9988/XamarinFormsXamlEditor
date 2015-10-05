using System.Collections.Generic;
using System.ComponentModel;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Designer.Services;
using ICSharpCode.WpfDesign.PropertyGrid;
using Xamarin.Forms;

namespace XamarinFormsClasses.Services
{
	public class XamarinFormsComponentPropertyService : ComponentPropertyService
	{
		public override IEnumerable<MemberDescriptor> GetAvailableProperties(DesignItem designItem)
		{
			if (designItem.Component is BindableObject)
			{
				return TypeHelper.GetAvailableProperties(designItem.ComponentType);
			}

			return base.GetAvailableProperties(designItem);
		}
	}
}
