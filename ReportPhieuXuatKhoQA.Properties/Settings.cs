using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ReportPhieuXuatKhoQA.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => defaultInstance;

	[SpecialSetting(SpecialSetting.ConnectionString)]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Data Source=192.168.1.2\\devqasol;Initial Catalog=Reports;User ID=thanhvc")]
	public string ReportsConnectionString => (string)this["ReportsConnectionString"];
}
