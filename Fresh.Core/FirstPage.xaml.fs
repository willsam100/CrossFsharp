namespace Fresh.Core

open Xamarin.Forms
open Xamarin.Forms.Xaml

type FirstPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<FirstPage>)
