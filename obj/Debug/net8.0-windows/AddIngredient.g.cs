﻿#pragma checksum "..\..\..\AddIngredient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FD458E9370413538E462CF2A56D0A12A96AE196D"
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
    /// AddIngredient
    /// </summary>
    public partial class AddIngredient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AddIngredientLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddIngredient;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IngredientNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quantitytxt;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumCaloriestxt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox unitComboBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\AddIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox foodGroupComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ProgPart3;component/addingredient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddIngredient.xaml"
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
            this.AddIngredientLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnAddIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\AddIngredient.xaml"
            this.btnAddIngredient.Click += new System.Windows.RoutedEventHandler(this.btnAddIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IngredientNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Quantitytxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NumCaloriestxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.unitComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.foodGroupComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

