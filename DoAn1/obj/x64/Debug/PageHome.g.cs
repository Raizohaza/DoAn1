﻿#pragma checksum "C:\Users\dung0\Desktop\New folder\DoAn1\PageHome.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1B1325CFD36D5462C1D850510F31B639"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1
{
    partial class PageHome : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // PageHome.xaml line 17
                {
                    this.GridHome = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // PageHome.xaml line 50
                {
                    this.test_data = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.test_data).RightTapped += this.test_data_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.test_data).SelectionChanged += this.test_data_SelectionChanged;
                }
                break;
            case 4: // PageHome.xaml line 73
                {
                    this.productTotalTb = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // PageHome.xaml line 78
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.PreviousButton_Click;
                }
                break;
            case 6: // PageHome.xaml line 79
                {
                    this.pageInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // PageHome.xaml line 80
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.NextButton_Click;
                }
                break;
            case 8: // PageHome.xaml line 58
                {
                    this.allContactsMenuFlyout = (global::Windows.UI.Xaml.Controls.MenuFlyout)(target);
                }
                break;
            case 9: // PageHome.xaml line 59
                {
                    this.Edit = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.Edit).Click += this.Edit_Click;
                }
                break;
            case 10: // PageHome.xaml line 60
                {
                    this.Remove = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.Remove).Click += this.Remove_Click;
                }
                break;
            case 12: // PageHome.xaml line 20
                {
                    this.cbbListType = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbbListType).RightTapped += this.cbbListType_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbbListType).SelectionChanged += this.cbbListType_SelectionChanged;
                }
                break;
            case 13: // PageHome.xaml line 35
                {
                    this.addCat = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.addCat).Click += this.addCat_Click;
                }
                break;
            case 14: // PageHome.xaml line 36
                {
                    this.cbbFillter = (global::Windows.UI.Xaml.Controls.DropDownButton)(target);
                }
                break;
            case 15: // PageHome.xaml line 39
                {
                    this.Filter = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 16: // PageHome.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element16 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element16).Click += this.option_Click;
                }
                break;
            case 17: // PageHome.xaml line 22
                {
                    this.cbbCF = (global::Windows.UI.Xaml.Controls.MenuFlyout)(target);
                }
                break;
            case 18: // PageHome.xaml line 24
                {
                    this.cbbEdit = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.cbbEdit).Click += this.cbbEdit_Click;
                }
                break;
            case 19: // PageHome.xaml line 25
                {
                    this.cbbRemove = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.cbbRemove).Click += this.cbbRemove_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

