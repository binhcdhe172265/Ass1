﻿#pragma checksum "..\..\..\CustomerInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6F3FDE4B556161B5A73DFE5F9EAD5169CC78AA7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PRN212Assignment01_WPF__LINQ;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PRN212Assignment01_WPF__LINQ {
    
    
    /// <summary>
    /// CustomerInfo
    /// </summary>
    public partial class CustomerInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFullName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelephone;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmailAddress;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBirthday;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBookRoom;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewBooking;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridBookings;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\CustomerInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRN212Assignment01_WPF _LINQ;component/customerinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomerInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtFullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTelephone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtEmailAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBirthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\CustomerInfo.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnBookRoom = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\CustomerInfo.xaml"
            this.btnBookRoom.Click += new System.Windows.RoutedEventHandler(this.btnBookRoom_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnViewBooking = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\CustomerInfo.xaml"
            this.btnViewBooking.Click += new System.Windows.RoutedEventHandler(this.ViewBooking_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridBookings = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\CustomerInfo.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

