using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Designer.Services;
using ICSharpCode.WpfDesign.PropertyGrid;
using XamarinFormsClasses.Base;

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
