﻿

#pragma checksum "C:\Users\wisani\Desktop\EMS_Mobile_App\EMS_Mobile_App\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2913F8BB88C4F39A21BD8144A74B5487"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS_Mobile_App
{
    partial class HomePage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnSendRequest; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnViewStatus; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button tbnUpdateDetails; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Maps.MapControl myMap; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock lblDisplayName; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView lstView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///HomePage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            btnSendRequest = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnSendRequest");
            btnViewStatus = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnViewStatus");
            tbnUpdateDetails = (global::Windows.UI.Xaml.Controls.Button)this.FindName("tbnUpdateDetails");
            myMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)this.FindName("myMap");
            lblDisplayName = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("lblDisplayName");
            lstView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("lstView");
        }
    }
}



