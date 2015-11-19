using System.Collections.Generic;
using System.Windows.Markup;

namespace Xamarin.Forms
{
	[ContentProperty("Children")]
	public class MultiPage : Page
    {
		private List<Page> _children = new List<Page>();
		public List<Page> Children
		{
			get { return _children; }
		}
	}
}
