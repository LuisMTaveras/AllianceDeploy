#if __ANDROID__
using Android.Content.PM;
#endif

namespace AllianceDeploy.View;

public partial class HomePage : ContentPage
{
	string nombreemp ="Alliance S.R.L";
    string version = "APP No Instalada";

    public HomePage()
	{
		InitializeComponent();
		this.Title = nombreemp;
         AppVersion.Text = GetWhatsAppVersion();

        if (version == ACT.Text)
        {
            Actualizacion.Text = "App Actualizada";
            siact.Text=Actualizacion.Text;
        }
        else {
            if (AppVersion.Text =="")
            {
                Actualizacion.Text = "NO SE PUEDE OBTENER LA VERCION DE LA APP";
                siact.Text = Actualizacion.Text;
            }
            else
            {
                Actualizacion.Text = "Actualizacion Disponible";
                siact.Text = Actualizacion.Text;
            }
        }
    }
    string GetWhatsAppVersion()
    {

#if __ANDROID__
            try
            {
                var context = Android.App.Application.Context;
                var packageManager = context.PackageManager;
                var packageInfo = packageManager.GetPackageInfo("com.alliance.rebs.cobrosappa", 0);
                version = packageInfo.VersionName;
            }
            catch (PackageManager.NameNotFoundException)
            {
                version = "APP No Instalada";
            }

#endif
       
        return version;
    }
}
