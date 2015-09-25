using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ComponentModel;
using Microsoft.Win32;
using ICSharpCode.WpfDesign.Designer;
using ICSharpCode.WpfDesign.Designer.PropertyGrid;
using XamarinFormsClasses.Pages;
using Xceed.Wpf.AvalonDock.Layout;

namespace ICSharpCode.XamlDesigner
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			Instance = this;
			DataContext = Shell.Instance;
			RenameCommands();
			BasicMetadata.Register();

			InitializeComponent();

			Shell.Instance.PropertyGrid = (PropertyGrid) uxPropertyGridView.PropertyGrid;
			AvalonDockWorkaround();
			RouteDesignSurfaceCommands();

			this.AddCommandHandler(RefreshCommand, Shell.Instance.Refresh, Shell.Instance.CanRefresh);

			LoadSettings();
			ProcessPaths(App.Args);
		    OpenDefaultAssemblys();
			
			ApplicationCommands.New.Execute(null, this);

            this.Loaded += MainWindow_Loaded;
		}

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

		public static MainWindow Instance;

		OpenFileDialog openFileDialog;
		SaveFileDialog saveFileDialog;

		protected override void OnDragEnter(DragEventArgs e)
		{
			ProcessDrag(e);
		}

		protected override void OnDragOver(DragEventArgs e)
		{
			ProcessDrag(e);
		}

		protected override void OnDrop(DragEventArgs e)
		{
			ProcessPaths(e.Data.Paths());
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (Shell.Instance.PrepareExit()) {
				SaveSettings();
			}
			else {
				e.Cancel = true;
			}
			base.OnClosing(e);
		}

		void RecentFiles_Click(object sender, RoutedEventArgs e)
		{
			var path = (string)(e.OriginalSource as MenuItem).Header;
			Shell.Instance.Open(path);
		}

		void ProcessDrag(DragEventArgs e)
		{
			e.Effects = DragDropEffects.None;
			e.Handled = true;

			foreach (var path in e.Data.Paths()) {
				if (path.EndsWith(".dll", StringComparison.InvariantCultureIgnoreCase) ||
				    path.EndsWith(".exe", StringComparison.InvariantCultureIgnoreCase)) {
					e.Effects = DragDropEffects.Copy;
					break;
				}
				else if (path.EndsWith(".xaml", StringComparison.InvariantCultureIgnoreCase)) {
					e.Effects = DragDropEffects.Copy;
					break;
				}
			}
		}

		void ProcessPaths(IEnumerable<string> paths)
		{
			foreach (var path in paths) {
				if (path.EndsWith(".xaml", StringComparison.InvariantCultureIgnoreCase)) {
					Shell.Instance.Open(path);
				}
			}
		}


        void OpenDefaultAssemblys()
        {
            //var fl = typeof (MccBackground).Assembly.CodeBase.Replace("file:///", "").Replace("/", "\\");
            //Toolbox.Instance.AddAssembly(fl);

            //fl = typeof(Chart).Assembly.CodeBase.Replace("file:///", "").Replace("/", "\\");
            //Toolbox.Instance.AddAssembly(fl);

            //fl = typeof(WPFDataForm).Assembly.CodeBase.Replace("file:///", "").Replace("/", "\\");
            //Toolbox.Instance.AddAssembly(fl);

            var fl = typeof(ContentPage).Assembly.CodeBase.Replace("file:///", "").Replace("/", "\\");
            Toolbox.Instance.AddAssembly(fl);
        }

		public string AskOpenFileName()
		{
			if (openFileDialog == null) {
				openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Xaml Documents (*.xaml)|*.xaml";
			}
			if ((bool)openFileDialog.ShowDialog()) {
				return openFileDialog.FileName;
			}
			return null;
		}

		public string AskSaveFileName(string initName)
		{
			if (saveFileDialog == null) {
				saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Xaml Documents (*.xaml)|*.xaml";
			}
			saveFileDialog.FileName = initName;
			if ((bool)saveFileDialog.ShowDialog()) {
				return saveFileDialog.FileName;
			}
			return null;
		}

		void LoadSettings()
		{
			
		}

		void SaveSettings()
		{
			
		}

		#region AvalonDockWorkaround

		void AvalonDockWorkaround()
		{
			uxDocumentPane.Children.KeepSyncronizedWith(Shell.Instance.Documents, d => CreateContentFor(d));
		}

        LayoutDocument CreateContentFor(Document doc)
        {
            var view = new DocumentView(doc);
            view.DataContext = doc;
            var content = new LayoutDocument()
            {
				Content = view
			};
            content.Title = doc.Title;
			return content;
		}

		#endregion
	}
}
