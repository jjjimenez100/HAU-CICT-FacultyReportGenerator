﻿#pragma checksum "..\..\..\User Forms\Profile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1725682CA8439E3301039D1ADEA1BEF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using ReportGenerator;
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


namespace ReportGenerator {
    
    
    /// <summary>
    /// Profile
    /// </summary>
    public partial class Profile : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox role;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox undergrad;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox postgrad;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox yearUnder;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox yearPost;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox yearExpected;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox subjectTB;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeCB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label delete;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Accept;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\User Forms\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/ReportGenerator;component/user%20forms/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User Forms\Profile.xaml"
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
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.role = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.undergrad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.postgrad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\User Forms\Profile.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.yearUnder = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.yearPost = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.yearExpected = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            
            #line 35 "..\..\..\User Forms\Profile.xaml"
            ((MaterialDesignThemes.Wpf.DialogHost)(target)).DialogClosing += new MaterialDesignThemes.Wpf.DialogClosingEventHandler(this.DialogHost_DialogClosing);
            
            #line default
            #line hidden
            return;
            case 11:
            this.subjectTB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\User Forms\Profile.xaml"
            this.subjectTB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.subjectTB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.typeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.delete = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.Accept = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\User Forms\Profile.xaml"
            this.Accept.Click += new System.Windows.RoutedEventHandler(this.Accept_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 54 "..\..\..\User Forms\Profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 17:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\User Forms\Profile.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\User Forms\Profile.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\User Forms\Profile.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

