﻿#pragma checksum "..\..\Watchlist.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83845D474109C2EEC5246598A0530DCB1DB8940B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hong_Kong_Movie_DataBase;
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


namespace Hong_Kong_Movie_DataBase {
    
    
    /// <summary>
    /// Watchlist
    /// </summary>
    public partial class Watchlist : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxWatchlist;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgWMoviePoster;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWName;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWReleaseDate;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWDirector;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWActor;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWRunningTime;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveWatchlist;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveFilm;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Watchlist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturn;
        
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
            System.Uri resourceLocater = new System.Uri("/Hong Kong Movie DataBase;component/watchlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Watchlist.xaml"
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
            
            #line 8 "..\..\Watchlist.xaml"
            ((Hong_Kong_Movie_DataBase.Watchlist)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbxWatchlist = ((System.Windows.Controls.ListBox)(target));
            
            #line 51 "..\..\Watchlist.xaml"
            this.lbxWatchlist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbxWatchlist_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imgWMoviePoster = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.lblWName = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblWReleaseDate = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblWDirector = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblWActor = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblWRunningTime = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.btnSaveWatchlist = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\Watchlist.xaml"
            this.btnSaveWatchlist.Click += new System.Windows.RoutedEventHandler(this.btnSaveWatchlist_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRemoveFilm = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\Watchlist.xaml"
            this.btnRemoveFilm.Click += new System.Windows.RoutedEventHandler(this.btnRemoveFilm_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\Watchlist.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.btnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

