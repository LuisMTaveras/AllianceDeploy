#if __ANDROID__
using Android.Content.PM;
#endif

namespace AllianceDeploy.View;

public partial class HomePage : ContentPage
{
    string nombreemp = "Alliance S.R.L";
    string version = "APP No Instalada";

    public HomePage()
    {
        InitializeComponent();
        this.Title = nombreemp;
        AppVersion.Text = GetWhatsAppVersion();
        FechaAppUpdate.Text = DateTime.Now.ToString("D");
    }
    string GetWhatsAppVersion()
    {
        string AppName;
        int TipoSistema = 1;

        if (TipoSistema == 1)
        {
            AppName = "com.alliance.rebs.pedidosapp";
            TipoApp.Text = "APP PEDIDOS";
            APPSERVER.Text = "11.0";
        }
        else
        {
            if (TipoSistema == 2)
            {
                AppName = "com.alliance.rebs.cobrosapp";
                TipoApp.Text = "APP COBROS";
                APPSERVER.Text = "4.0";
            }
            else
            {
                AppName = "com.alliance.rebs.gasolinerasapp";
                TipoApp.Text = "APP GASOLINERA";
                APPSERVER.Text = "1.0";
            }
        }
#if __ANDROID__
            try
            {
                var context = Android.App.Application.Context;
                var packageManager = context.PackageManager;
                var packageInfo = packageManager.GetPackageInfo(AppName, 0);
                version = packageInfo.VersionName;
            }
            catch (PackageManager.NameNotFoundException)
            {
                version = "APP No Instalada";
            }
#endif
        return version;
    }

    private void HistorialCambios_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Tapped", "Frame tapped!", "OK");
    }
}
