﻿#pragma checksum "..\..\MainWindowEnglish.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633CC13986C9FD430B09C24C945B063029E7B0BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EBookDat;
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


namespace EBookDat {
    
    
    /// <summary>
    /// MainWindowEnglish
    /// </summary>
    public partial class MainWindowEnglish : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 122 "..\..\MainWindowEnglish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\MainWindowEnglish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox searchComboBox;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\MainWindowEnglish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView booksListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/EBookDat;component/mainwindowenglish.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindowEnglish.xaml"
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
            
            #line 58 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DataExportovatExcelMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 63 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DataImportovatExcelMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 68 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DataImportovatNovyExcelMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 76 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.EdiceSpravovatEdiceMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 84 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ZanrySpravovarZanryMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 96 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CzechMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\MainWindowEnglish.xaml"
            this.searchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.searchComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 128 "..\..\MainWindowEnglish.xaml"
            this.searchComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SearchComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.booksListBox = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            
            #line 152 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.TitleGridViewColumnHeader_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 155 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.AuthorGridViewColumnHeader_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 158 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.EditionGridViewColumnHeader_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 161 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.GenreGridViewColumnHeader_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 164 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.NoteGridViewColumnHeader_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 228 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 229 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 230 "..\..\MainWindowEnglish.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
