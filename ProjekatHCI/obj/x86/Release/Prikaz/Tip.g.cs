﻿#pragma checksum "..\..\..\..\Prikaz\Tip.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D456DDD93ED44B0B8785FC42F30C0121105F7404E09D88DFE7E343B4A6FDEFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjekatHCI.Unos;
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


namespace ProjekatHCI.Prikaz {
    
    
    /// <summary>
    /// Tip
    /// </summary>
    public partial class Tip : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Prikaz\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dodajBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Prikaz\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button obrisiBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Prikaz\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listaTipova;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Prikaz\Tip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazivTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjekatHCI;component/prikaz/tip.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Prikaz\Tip.xaml"
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
            this.dodajBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\Prikaz\Tip.xaml"
            this.dodajBtn.Click += new System.Windows.RoutedEventHandler(this.DodajBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.obrisiBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Prikaz\Tip.xaml"
            this.obrisiBtn.Click += new System.Windows.RoutedEventHandler(this.ObrisiBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listaTipova = ((System.Windows.Controls.ListView)(target));
            
            #line 12 "..\..\..\..\Prikaz\Tip.xaml"
            this.listaTipova.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListaTipova_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.nazivTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

