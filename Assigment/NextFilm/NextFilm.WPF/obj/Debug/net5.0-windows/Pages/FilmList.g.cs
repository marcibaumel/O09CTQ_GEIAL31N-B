﻿#pragma checksum "..\..\..\..\Pages\FilmList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8297745B267A5EF4150F86D6E51C7E7B67164249"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NextFilm.WPF.Pages;
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


namespace NextFilm.WPF.Pages {
    
    
    /// <summary>
    /// FilmList
    /// </summary>
    public partial class FilmList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showAddFilmBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel addFilmPanel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filmTitleInput;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filmYearInput;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClcikAddFilm;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel filmList;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\FilmList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView FilmBinding;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NextFilm.WPF;component/pages/filmlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\FilmList.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\Pages\FilmList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickLogout);
            
            #line default
            #line hidden
            return;
            case 2:
            this.showAddFilmBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Pages\FilmList.xaml"
            this.showAddFilmBtn.Click += new System.Windows.RoutedEventHandler(this.BtnClickShowAddFilm);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addFilmPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.filmTitleInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.filmYearInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnClcikAddFilm = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\FilmList.xaml"
            this.BtnClcikAddFilm.Click += new System.Windows.RoutedEventHandler(this.BtnAddFilm);
            
            #line default
            #line hidden
            return;
            case 7:
            this.filmList = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.FilmBinding = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

