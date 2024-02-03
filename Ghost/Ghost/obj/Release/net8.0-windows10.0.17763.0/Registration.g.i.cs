﻿#pragma checksum "..\..\..\Registration.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276B88850074C7207991CB7E700E8A598A3D3821"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Ghost;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Ghost {
    
    
    /// <summary>
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox username_tb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_tb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password_tb;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fullName_tb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reg_btn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_btn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openLoginForm;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton male;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton female;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date_bth;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox lang_cb;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox languageListBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label msg;
        
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
            System.Uri resourceLocater = new System.Uri("/Ghost;V1.0.0.0;component/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Registration.xaml"
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
            this.username_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.email_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.password_tb = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.fullName_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.reg_btn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Registration.xaml"
            this.reg_btn.Click += new System.Windows.RoutedEventHandler(this.reg_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.clear_btn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Registration.xaml"
            this.clear_btn.Click += new System.Windows.RoutedEventHandler(this.clear_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.openLoginForm = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Registration.xaml"
            this.openLoginForm.Click += new System.Windows.RoutedEventHandler(this.openLoginForm_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.male = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.female = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.date_bth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            this.lang_cb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.languageListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 13:
            this.msg = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
