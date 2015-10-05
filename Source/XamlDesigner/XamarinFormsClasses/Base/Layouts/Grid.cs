using System.Windows;

namespace Xamarin.Forms
{
    public class Grid : Layout
    {
		public ColumnDefinitionCollection Columns
		{
			get { return (ColumnDefinitionCollection)GetValue(ColumnsProperty); }
			set { SetValue(ColumnsProperty, value); }
		}

		public static readonly DependencyProperty ColumnsProperty =
			DependencyProperty.Register("Columns", typeof(ColumnDefinitionCollection), typeof(Grid), new PropertyMetadata(null));
    }
}
