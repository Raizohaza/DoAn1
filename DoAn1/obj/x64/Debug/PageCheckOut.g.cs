﻿#pragma checksum "C:\Users\dung0\Desktop\New folder\DoAn1\PageCheckOut.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "50811A132A8852B7B1D8CED0EF936AD3"
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
    partial class PageCheckOut : 
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
            case 2: // PageCheckOut.xaml line 104
                {
                    this.relativePanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3: // PageCheckOut.xaml line 108
                {
                    this.addItemPopup = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 4: // PageCheckOut.xaml line 126
                {
                    this.Confirm = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Confirm).Click += this.Confirm_Click;
                }
                break;
            case 5: // PageCheckOut.xaml line 127
                {
                    this.productsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.productsListView).SelectionChanged += this.productsListView_SelectionChanged;
                }
                break;
            case 7: // PageCheckOut.xaml line 38
                {
                    this.purchaseStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8: // PageCheckOut.xaml line 83
                {
                    this.purchaseDataGrid = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                    ((global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)this.purchaseDataGrid).SelectionChanged += this.purchaseDataGrid_SelectionChanged;
                }
                break;
            case 9: // PageCheckOut.xaml line 98
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.PreviousButton_Click;
                }
                break;
            case 10: // PageCheckOut.xaml line 99
                {
                    this.pageInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // PageCheckOut.xaml line 100
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.NextButton_Click;
                }
                break;
            case 12: // PageCheckOut.xaml line 89
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element12 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element12).Click += this.editPurchase_MenuItem_Click;
                }
                break;
            case 13: // PageCheckOut.xaml line 90
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element13 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element13).Click += this.deletePurchase_MenuItem_Click;
                }
                break;
            case 14: // PageCheckOut.xaml line 39
                {
                    this.CustomerStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 15: // PageCheckOut.xaml line 62
                {
                    this.DataGridDetailPurchase = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                }
                break;
            case 16: // PageCheckOut.xaml line 74
                {
                    this.btnAddItem = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddItem).Click += this.btnAddItem_Click;
                }
                break;
            case 17: // PageCheckOut.xaml line 79
                {
                    this.btnDone = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDone).Click += this.btnDone_Click;
                }
                break;
            case 18: // PageCheckOut.xaml line 76
                {
                    this.btnDeleteItem = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDeleteItem).Click += this.btnDeleteItem_Click;
                }
                break;
            case 19: // PageCheckOut.xaml line 77
                {
                    this.btnUpdate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUpdate).Click += this.btnUpdate_Click;
                }
                break;
            case 20: // PageCheckOut.xaml line 58
                {
                    this.customerEmailTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21: // PageCheckOut.xaml line 54
                {
                    this.customerAddressTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 22: // PageCheckOut.xaml line 47
                {
                    this.customerTelTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 23: // PageCheckOut.xaml line 43
                {
                    this.customerNameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 24: // PageCheckOut.xaml line 21
                {
                    this.fromDatePicker = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.fromDatePicker).DateChanged += this.fromDatePicker_DateChanged;
                }
                break;
            case 25: // PageCheckOut.xaml line 23
                {
                    this.toDatePicker = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.toDatePicker).DateChanged += this.toDatePicker_DateChanged;
                }
                break;
            case 26: // PageCheckOut.xaml line 25
                {
                    this.purchaseStatesComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.purchaseStatesComboBox).SelectionChanged += this.purchaseStatesComboBox_SelectionChanged;
                }
                break;
            case 27: // PageCheckOut.xaml line 32
                {
                    this.btnComplexFilter = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnComplexFilter).Click += this.btnComplexFilter_Click;
                }
                break;
            case 28: // PageCheckOut.xaml line 33
                {
                    this.SearchBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.SearchBox).TextChanged += this.SearchBox_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.SearchBox).QuerySubmitted += this.SearchBox_QuerySubmitted;
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

