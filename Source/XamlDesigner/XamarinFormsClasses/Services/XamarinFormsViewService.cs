/*
 * Created by SharpDevelop.
 * User: Jochen Kühner
 * Date: 24.10.2015
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using ICSharpCode.WpfDesign;

namespace Xamarin.Forms.Services
{
	/// <summary>
	/// Description of XamarinFormsViewService.
	/// </summary>
	public class XamarinFormsViewService : ViewService
	{
		readonly DesignContext context;
		
		public XamarinFormsViewService(DesignContext context)
		{
			this.context = context;
		}
		
		public override DesignItem GetModel(System.Windows.DependencyObject view)
		{
			return context.Services.Component.GetDesignItem(view, true);
		}
	}
}
