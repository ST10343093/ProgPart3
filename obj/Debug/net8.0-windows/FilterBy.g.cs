﻿#pragma checksum "..\..\..\FilterBy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182B38C452283FA9439FA7CE62B64D47A0846F41"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgPart3;
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


namespace ProgPart3 {
    
    
    /// <summary>
    /// FilterBy
    /// </summary>
    public partial class FilterBy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NameFilterBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FoodGroupFilterBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CaloriesFilterBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyFilterBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxRecipes;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewRecipeBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTxt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGroup;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\FilterBy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaloriesTxt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgPart3;component/filterby.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FilterBy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NameFilterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\FilterBy.xaml"
            this.NameFilterBtn.Click += new System.Windows.RoutedEventHandler(this.NameFilterBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FoodGroupFilterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\FilterBy.xaml"
            this.FoodGroupFilterBtn.Click += new System.Windows.RoutedEventHandler(this.FoodGroupFilterBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CaloriesFilterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\FilterBy.xaml"
            this.CaloriesFilterBtn.Click += new System.Windows.RoutedEventHandler(this.CaloriesFilterBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ApplyFilterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\FilterBy.xaml"
            this.ApplyFilterBtn.Click += new System.Windows.RoutedEventHandler(this.ApplyFilterBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbxRecipes = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ViewRecipeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\FilterBy.xaml"
            this.ViewRecipeBtn.Click += new System.Windows.RoutedEventHandler(this.ViewRecipeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MainMenuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\FilterBy.xaml"
            this.MainMenuBtn.Click += new System.Windows.RoutedEventHandler(this.MainMenuBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cmbGroup = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.CaloriesTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
