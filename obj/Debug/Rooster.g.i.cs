﻿#pragma checksum "..\..\rooster.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B03731D324A83C73E663645896ABA971"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Het_Terras;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Het_Terras {
    
    
    /// <summary>
    /// rooster
    /// </summary>
    public partial class rooster : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid contentGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid navGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dashboardButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button roosterButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button personeelButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quitButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label welkomLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid footerGrid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RoosterdataGrid;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addDataButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\rooster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editDataButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Het Terras;component/rooster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\rooster.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.contentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.navGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.dashboardButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\rooster.xaml"
            this.dashboardButton.Click += new System.Windows.RoutedEventHandler(this.dashboardButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.roosterButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.personeelButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\rooster.xaml"
            this.personeelButton.Click += new System.Windows.RoutedEventHandler(this.personeelButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.quitButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\rooster.xaml"
            this.quitButton.Click += new System.Windows.RoutedEventHandler(this.quitButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.welkomLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.footerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.RoosterdataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.addDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\rooster.xaml"
            this.addDataButton.Click += new System.Windows.RoutedEventHandler(this.addDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.editDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\rooster.xaml"
            this.editDataButton.Click += new System.Windows.RoutedEventHandler(this.editDataButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

