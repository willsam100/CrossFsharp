namespace Fresh.Core.ViewModels
open MvvmCross.Core.ViewModels
open MvvmCross.Core.Views
open System.Windows.Input

type FirstPageViewModel() =
    inherit MvxViewModel()

    let mutable myList = List.empty<string>
    let mutable _yourNickname: string = "";

    member val MyProperty = "" with get, set

    member this.MyList
        with get() = myList |> List.toSeq
        and set(value) =
            myList <- Seq.toList value
            this.RaisePropertyChanged(fun () -> myList)
        
    //member this.YourNickname() = "Bar"
    //member this.doSomething() = -1



    member this.YourNickname
        with get() =  _yourNickname;
        and set(value: string) = 
            _yourNickname <- value; 
            this.RaisePropertyChanged("YourNickname"); 
            this.RaisePropertyChanged("Hello")
    
    member this.Hello() = "Hello " + this.YourNickname; 


    //member this.ShowAboutPageCommand() = new MvxCommand(() => this.ShowViewModel<AboutViewModel>());
            
        
    
