﻿#pragma checksum "..\..\..\CheckBoxDemo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09CAB903AB017099FCA3FA54360EBEDAC4BAF0CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Control;
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


namespace Control {
    
    
    /// <summary>
    /// CheckBoxDemo
    /// </summary>
    public partial class CheckBoxDemo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CheckBoxDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbChoc;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CheckBoxDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbSugar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CheckBoxDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CheckBoxDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Control;component/checkboxdemo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CheckBoxDemo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cbChoc = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\..\CheckBoxDemo.xaml"
            this.cbChoc.Checked += new System.Windows.RoutedEventHandler(this.cbChoc_Checked);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\CheckBoxDemo.xaml"
            this.cbChoc.Unchecked += new System.Windows.RoutedEventHandler(this.cbChoc_UnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbSugar = ((System.Windows.Controls.CheckBox)(target));
            
            #line 14 "..\..\..\CheckBoxDemo.xaml"
            this.cbSugar.Checked += new System.Windows.RoutedEventHandler(this.cbSugar_Checked);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\CheckBoxDemo.xaml"
            this.cbSugar.Unchecked += new System.Windows.RoutedEventHandler(this.cbSugar_UnChecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
