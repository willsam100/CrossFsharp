namespace Fresh.Droid
open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.Runtime
open Android.Views
open Android.Widget
open Android.OS
open MvvmCross.Droid.Views
open Xamarin.Android.FSharp

open Android.Content;
open MvvmCross.Platform;
open MvvmCross.Platform.Platform;
open MvvmCross.Droid.Platform;
open MvvmCross.Droid.Views;
open MvvmCross.Core.ViewModels;
open MvvmCross.Core.Views;
open MvvmCross.Forms.Presenter.Droid
open MvvmCross.Forms.Presenter.Core

type Setup(applicationContext: Context) = 
    inherit MvxAndroidSetup(applicationContext)
    override this.CreateApp(): IMvxApplication = new Fresh.Core.App() :> IMvxApplication

    //override this.CreateViewPresenter(): IMvxAndroidViewPresenter = 
        
    //    let presenter = new MvxPagePresenter();
    //    Mvx.RegisterSingleton<IMvxPageNavigationHost>(presenter);
    //    presenter
        
        

type Resources = Fresh.Droid.Resource


//[<Activity (Label = "Fresh.Droid")>]
//type MainActivity() =
//    inherit Xamarin.Forms.Platform.Android.FormsApplicationActivity()
//    override this.OnCreate (bundle: Bundle) =
//        base.OnCreate (bundle)

//        Xamarin.Forms.Forms.Init (this, bundle)

//        let app = (new MvxFormsApp ()) :> Xamarin.Forms.Application
//        this.LoadApplication (app)

//        let presenter = Mvx.Resolve<IMvxViewPresenter>() :?> MvxFormsDroidPagePresenter;
//        presenter.MvxFormsApp <- app;

//        Mvx.Resolve<IMvxAppStart>().Start();



[<Activity (Label = "Fresh.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type SplashScreen() =
    inherit MvxSplashScreenActivity()




    //let mutable isInitializationComplete = false;
    //override this.InitializationComplete() = 
    //    if (not isInitializationComplete) then 
    //        isInitializationComplete <- true;
            //this.StartActivity(typeof<MainActivity>);

    override this.OnCreate(bundle: Android.OS.Bundle) = 
        this.RequestWindowFeatures();
        //Xamarin.Forms.Forms.Init(this, bundle)

        //// Leverage controls' StyleId attrib. to Xamarin.UITest
        //Xamarin.Forms.Forms.ViewInitialized.AddHandler <| fun (ViewInitializedEventArgs e) ->
        //    if (!string.IsNullOrWhiteSpace(e.View.StyleId)) then
        //        e.NativeView.ContentDescription = e.View.StyleId;

        //base.OnCreate(bundle);



