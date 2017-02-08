namespace Fresh.Core

open System
open Xamarin.Forms

type App() = 
    inherit MvvmCross.Core.ViewModels.MvxApplication()
 
     override this.Initialize() =
         this.RegisterAppStart<ViewModels.FirstPageViewModel>()
     
 


//type App() =
//    static member GetMainPage =
//        let button = Button(Text = "Click Me!",
//                            VerticalOptions = LayoutOptions.CenterAndExpand,
//                            HorizontalOptions = LayoutOptions.CenterAndExpand)
//        ContentPage(Title = "My content page", Content = button)
