# MultipleViewModelSample
An iOS and Anrdoid app built using Xamarin.Forms demonstrating how to have multiple views reference two different ViewModels from the same ContentPage


```csharp
<?xml version="1.0" encoding="utf-8"?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms" 
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
             xmlns:local="clr-namespace:MultipleViewModelSample" 
             x:Class="MultipleViewModelSample.MainPage">
    
    <StackLayout
        HorizontalOptions="Center"
        VerticalOptions="Center">
        
        <Label 
            x:Name="ViewModel1Label" 
            BindingContext="{Binding Source ={local:ViewModel1 }}" 
            Text="{Binding LabelText}" 
            HorizontalOptions="Center" 
            HorizontalTextAlignment="Center" />
        <Label 
            x:Name="ViewModel2Label" 
            BindingContext="{Binding Source ={local:ViewModel2 }}" 
            Text="{Binding LabelText}" 
            HorizontalOptions="Center" 
            HorizontalTextAlignment="Center" />
        
    </StackLayout>
    
</ContentPage>
```
