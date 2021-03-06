using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.StyleSheets;
using System.Reflection;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin.Forms.Sandbox
{
	public partial class App : Application
	{
		public App()
		{
			InitializeMainPage();
		}

		void AddStyleSheet()
		{
			this.Resources.Add(StyleSheet.FromResource(
				"Styles.css",
				IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly));
		}

		void InitializeLegacyRenderers()
		{
			var flags = new List<String>(Device.Flags);
			flags.Add("UseLegacyRenderers");
			Device.SetFlags(flags.Select(x => x).Distinct().ToArray());
		}

		protected override void OnStart()
		{
			base.OnStart();
		}
	}
}
