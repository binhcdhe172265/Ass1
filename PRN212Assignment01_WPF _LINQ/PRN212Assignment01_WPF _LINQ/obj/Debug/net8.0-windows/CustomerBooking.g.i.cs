﻿#pragma checksum "..\..\..\CustomerBooking.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14E674059DD40D1A20A1EA639BC1AB758290853B"
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
    /// CustomerBooking
    /// </summary>
    public partial class CustomerBooking : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpkStartDate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpkEndDate;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxRoomType;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\CustomerBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInsert;
        
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
            System.Uri resourceLocater = new System.Uri("/PRN212Assignment01_WPF _LINQ;component/customerbooking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomerBooking.xaml"
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
            
            #line 8 "..\..\..\CustomerBooking.xaml"
            ((PRN212Assignment01_WPF__LINQ.CustomerBooking)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\CustomerBooking.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dpkStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.dpkEndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.cbxRoomType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\CustomerBooking.xaml"
            this.cbxRoomType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxRoomType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbxRoomNumber = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\CustomerBooking.xaml"
            this.cbxRoomNumber.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxRoomNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtTotalPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnInsert = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\CustomerBooking.xaml"
            this.btnInsert.Click += new System.Windows.RoutedEventHandler(this.btnInsert_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

