﻿#pragma checksum "..\..\FTPWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51211165CF8E94ABF6CEB0F0084E39FD777DF73B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DirectConnectionPredictControl;
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


namespace DirectConnectionPredictControl {
    
    
    /// <summary>
    /// FTPWindow
    /// </summary>
    public partial class FTPWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem login;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem exit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem about;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FormerDir;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView FTPListView;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu contextMenu;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DeleteItem;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock progressValue;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock process;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\FTPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/DirectConnectionPredictControl;component/ftpwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FTPWindow.xaml"
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
            this.login = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\FTPWindow.xaml"
            this.login.Click += new System.Windows.RoutedEventHandler(this.login_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\FTPWindow.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.about = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\FTPWindow.xaml"
            this.about.Click += new System.Windows.RoutedEventHandler(this.about_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FormerDir = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\FTPWindow.xaml"
            this.FormerDir.Click += new System.Windows.RoutedEventHandler(this.FormerDir_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\FTPWindow.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FTPListView = ((System.Windows.Controls.ListView)(target));
            
            #line 62 "..\..\FTPWindow.xaml"
            this.FTPListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FTPListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.contextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 8:
            this.DeleteItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 76 "..\..\FTPWindow.xaml"
            this.DeleteItem.Click += new System.Windows.RoutedEventHandler(this.DeleteItem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 10:
            this.slider = ((System.Windows.Controls.Slider)(target));
            return;
            case 11:
            this.progressValue = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.process = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\FTPWindow.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

