﻿#pragma checksum "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D7FC45E927ACEEA821597F2C0A394C912900F38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GestaoRHWPF.Views.Remover;
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


namespace GestaoRHWPF.Views.Remover {
    
    
    /// <summary>
    /// frmRemoverCaixa
    /// </summary>
    public partial class frmRemoverCaixa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumeroCaixa;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustodia;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCriadoEm;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarCaixa;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoverCaixa;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestaoRHWPF;component/views/remover/frmremovercaixa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNumeroCaixa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtCustodia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCriadoEm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnBuscarCaixa = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
            this.btnBuscarCaixa.Click += new System.Windows.RoutedEventHandler(this.btnBuscarCaixa_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemoverCaixa = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Views\Remover\frmRemoverCaixa.xaml"
            this.btnRemoverCaixa.Click += new System.Windows.RoutedEventHandler(this.btnRemoverCaixa_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

