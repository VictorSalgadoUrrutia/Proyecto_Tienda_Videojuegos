﻿#pragma checksum "..\..\..\ventanaVendedor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CD317F26E493E85859AE8D355337261A3F09EC1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_majo;
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


namespace Proyecto_majo {
    
    
    /// <summary>
    /// ventanaVendedor
    /// </summary>
    public partial class ventanaVendedor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAgregarP;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditarP;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnActualizarP;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminarP;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProductosP;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSalir;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ventanaVendedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto majo;component/ventanavendedor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ventanaVendedor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\ventanaVendedor.xaml"
            ((Proyecto_majo.ventanaVendedor)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnAgregarP = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\ventanaVendedor.xaml"
            this.BtnAgregarP.Click += new System.Windows.RoutedEventHandler(this.BtnAgregarP_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnEditarP = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\ventanaVendedor.xaml"
            this.BtnEditarP.Click += new System.Windows.RoutedEventHandler(this.BtnEditarP_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnActualizarP = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\ventanaVendedor.xaml"
            this.BtnActualizarP.Click += new System.Windows.RoutedEventHandler(this.BtnActualizarP_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEliminarP = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\ventanaVendedor.xaml"
            this.BtnEliminarP.Click += new System.Windows.RoutedEventHandler(this.BtnEliminarP_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnProductosP = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\ventanaVendedor.xaml"
            this.BtnProductosP.Click += new System.Windows.RoutedEventHandler(this.BtnProductosP_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\ventanaVendedor.xaml"
            this.BtnSalir.Click += new System.Windows.RoutedEventHandler(this.BtnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

