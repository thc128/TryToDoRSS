﻿#pragma checksum "C:\Users\asaf\Documents\GitHub\TryToDoRSS\TryToDoRSS\SearchView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0F86FCD862918868041BF140D24BABE4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryToDoRSS
{
    partial class SearchView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MainPageButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\SearchView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MainPageButton).Click += this.MainPageButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.SearchButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\SearchView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SearchButton).Click += this.SearchButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.SearchText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.ResultText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

