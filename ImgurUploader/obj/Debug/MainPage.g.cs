﻿

#pragma checksum "C:\Users\lijam_000\Documents\GitHub\ImgurUploader\ImgurUploader\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "58C46CCB4CAEC0648521B4A1F52CDF78"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImgurUploader
{
    partial class MainPage : global::ImgurUploader.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 21 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SelectAllButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 22 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddImageButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 23 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RemoveImageButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 90 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.ItemTitleTextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 92 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.ItemDescriptionTextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 77 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.QueuedImagesListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 52 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.UploadImagesButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


