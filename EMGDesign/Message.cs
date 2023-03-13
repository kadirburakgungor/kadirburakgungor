using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using DevExpress.XtraLayout;
using System.Data.SqlClient;
using EMGDesign;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Diagnostics;
using System.Data;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors.Repository;

public static class Message
{

    public static void ErrorMessage(string Error, string Caption)
    {
        EMGMessage.MesajBox(Error, Caption, MsgButton.Ok, MsgImg.Error);
    }

    public static void InfoMessage(string Info, string Caption)
    {
        EMGMessage.MesajBox(Info, Caption, MsgButton.Ok, MsgImg.Information);
    }

    public static void WarningMessage(string Warning, string Caption)
    {
        EMGMessage.MesajBox(Warning, Caption, MsgButton.Ok, MsgImg.Warning);
    }

    public static DialogResult QuestionMessage(string Question, string Caption)
    {
        EMGMessage.MesajBox(Question, Caption, MsgButton.YesNo, MsgImg.Question);
        return EMGMessage.Result;
    }

}

public static class Extension
{
    public static string ToStr(this object val)
    {
        try
        {
            if (val == null) return "";

            return val.ToString();
        }
        catch { }

        return string.Empty;
    }
    public static string ToKodFormat(this int val)
    {
        try
        {
            if (val < 10)
            {
                return "000" + val;
            }
            else if (val < 100)
            {
                return "00" + val;
            }
            else if (val < 1000)
            {
                return "0" + val;
            }
            else
            {
                return val.ToString();
            }
        }
        catch { }

        return "0000";
    }
    public static int ToInt(this object val)
    {
        try
        {
            if (val == null) return 0;
            return Convert.ToInt32(val.ToString());
        }
        catch { }

        return 0;
    }
    public static Boolean ToBool(this object val)
    {
        try
        {
            if (val == null) return false;
            return Convert.ToBoolean(val.ToString());
        }
        catch { }

        return false;
    }
    public static double ToDbl(this object val)
    {
        if (val == null) return 0.0;
        Double result = 0;
        try
        {
            return Convert.ToDouble(val.ToStr().Replace(" TL", ""));
            //System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "-";
            string DecimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            string GroupSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator;

            string[] split = val.ToStr().Replace(" TL", "").Split(Convert.ToChar(DecimalSeparator));
            if (split.Length > 1)
                result = Convert.ToDouble(split[1].ToInt()) / 100;

            List<double> carpan = new List<double>()
            {
                1,
                1000,
                1000000,
                1000000000,
                1000000000000,


            };
            string[] split2 = split[0].Split(Convert.ToChar(GroupSeparator));
            for (int i = 0; i < split2.Length; i++)
            {
                result += split2[i].ToInt() * carpan[split2.Length - 1 - i];
            }
            //string Result = "";
            //foreach (char item in val.ToStr())
            //{
            //    if (char.IsNumber(item))
            //    {
            //        Result += item;
            //    }
            //    else
            //    {

            //        if (item.ToString() == "." || item.ToString() == ",")
            //        {
            //            Result += item;
            //        }
            //    }
            //}
            // return Convert.ToDouble(Result.ToStr().Replace(",", DecimalSeparator).Replace(".", DecimalSeparator));
            return Convert.ToDouble(result);
        }
        catch (Exception)
        {

            try
            {
                return Convert.ToDouble(val.ToString());
            }
            catch { }
        }


        return 0;
    }
    public static Decimal ToDcml(this object val)
    {
        if (val == null) return Convert.ToDecimal(0);
        Decimal result = 0;
        try
        {
            return Convert.ToDecimal(val.ToStr().Replace(" TL", ""));
            //System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "-";
            string DecimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            string GroupSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator;

            string[] split = val.ToStr().Replace(" TL", "").Split(Convert.ToChar(DecimalSeparator));
            if (split.Length > 1)
                result = Convert.ToDecimal(Convert.ToDecimal(split[1].ToInt()) / Convert.ToDecimal(100));

            List<double> carpan = new List<double>()
            {
                1,
                1000,
                1000000,
                1000000000,
                1000000000000,


            };
            string[] split2 = split[0].Split(Convert.ToChar(GroupSeparator));
            for (int i = 0; i < split2.Length; i++)
            {
                result += Convert.ToDecimal(split2[i].ToInt() * carpan[split2.Length - 1 - i]);
            }
            //string Result = "";
            //foreach (char item in val.ToStr())
            //{
            //    if (char.IsNumber(item))
            //    {
            //        Result += item;
            //    }
            //    else
            //    {

            //        if (item.ToString() == "." || item.ToString() == ",")
            //        {
            //            Result += item;
            //        }
            //    }
            //}
            // return Convert.ToDouble(Result.ToStr().Replace(",", DecimalSeparator).Replace(".", DecimalSeparator));
            return Convert.ToDecimal(result);
        }
        catch (Exception)
        {

            try
            {
                return Convert.ToDecimal(val.ToString());
            }
            catch { }
        }


        return 0;
    }
    public static DateTime ToDate(this object val)
    {
        try
        {
            if (val == null) return DateTime.MinValue;
            return Convert.ToDateTime(val.ToString());
        }
        catch { }

        return DateTime.MinValue;
    }
    public static DateTime ConvertToDateTime(this object excelDate)
    {
        if ((double)excelDate < 1)
        {
            throw new ArgumentException("Excel dates cannot be smaller than 0.");
        }
        DateTime dateOfReference = new DateTime(1900, 1, 1);
        if ((double)excelDate > 60d)
        {
            excelDate = (double)excelDate - 2;
        }
        else
        {
            excelDate = (double)excelDate - 1;
        }
        return dateOfReference.AddDays((double)excelDate);
    }

}

public static class EMGFormEvents
{

    /// <summary>
    /// Formu Doldurur
    /// </summary>
    /// <param name="lc"></param>
    /// <param name="obj"></param>
    /// 
    public static void ClassToForm(LayoutControl lc, object obj)
    {
        foreach (PropertyInfo item in obj.GetType().GetProperties())
        {

            Control control = lc.Controls["txt" + item.Name];
            if (control == null) continue;

            //TextEdit                 
            if (control.GetType().Name == "TextEdit")
            {
                ((TextEdit)control).EditValue = item.GetValue(obj, null);
            }
          
            //MemoEdit
            else if (control.GetType().Name == "MemoEdit")
            {
                ((MemoEdit)control).Text = item.GetValue(obj, null).ToStr();
            }
            //LookUpEdit
            else if (control.GetType().Name == "LookUpEdit")
            {
                ((LookUpEdit)control).Properties.GetType().GetProperty("KeyValue").SetValue(((LookUpEdit)control).Properties, GetDefaultValue(item.GetValue(obj, null), typeof(Int32)), null);
            }
          
            //RadioGroup
            else if (control.GetType().Name == "RadioGroup")
            {
                ((RadioGroup)control).SelectedIndex = item.GetValue(obj, null).ToInt();
            }
            //CheckEdit
            else if (control.GetType().Name == "CheckEdit")
            {
                ((CheckEdit)control).Checked = Convert.ToBoolean(item.GetValue(obj, null));
            }
            //DateEdit
            else if (control.GetType().Name == "DateEdit")
            {
                DateTime dt = Convert.ToDateTime(item.GetValue(obj, null));
                if (dt == DateTime.MinValue)
                    ((DateEdit)control).Text = null;
                else
                    ((DateEdit)control).DateTime = dt;
            }
          
            //ComboBoxEdit
            else if (control.GetType().Name == "ComboBoxEdit")
            {
                ((ComboBoxEdit)control).Text = (item.GetValue(obj, null)).ToStr();

            }
         
            //ButtonEdit
            else if (control.GetType().Name == "ButtonEdit")
            {
                ((ButtonEdit)control).Text = (item.GetValue(obj, null)).ToStr();

            }
            //Diğer   
            else
            {

            }

        }

    }

    /// <summary>
    /// Classı Doldurur
    /// </summary>
    /// <param name="lc"></param>
    /// <param name="obj"></param>
    public static void FormToClass(LayoutControl lc, object obj)
    {
        foreach (PropertyInfo item in obj.GetType().GetProperties())
        {

            Control control = lc.Controls["txt" + item.Name];
            if (control == null) continue;

            //TextEdit
            if (control.GetType().Name == "TextEdit")
            {
                item.SetValue(obj, GetDefaultValue(((TextEdit)control).Text, item.PropertyType), null);
            }
       
            //MemoEdit
            else if (control.GetType().Name == "MemoEdit")
            {
                item.SetValue(obj, GetDefaultValue(((MemoEdit)control).Text, item.PropertyType), null);
            }
            //LookUpEdit
            else if (control.GetType().Name == "LookUpEdit")
            {
                item.SetValue(obj, GetDefaultValue(((LookUpEdit)control).Properties.GetType().GetProperty("KeyValue").GetValue(((LookUpEdit)control).Properties, null), item.PropertyType), null);
            }
         
            //RadioGroup
            else if (control.GetType().Name == "RadioGroup")
            {

                item.SetValue(obj, GetDefaultValue(((RadioGroup)control).SelectedIndex, item.PropertyType), null);
            }
            //CheckEdit
            else if (control.GetType().Name == "CheckEdit")
            {

                item.SetValue(obj, GetDefaultValue(((CheckEdit)control).Checked, item.PropertyType), null);
            }
            //DateEdit
            else if (control.GetType().Name == "DateEdit")
            {
                item.SetValue(obj, GetDefaultValue(((DateEdit)control).DateTime, item.PropertyType), null);

            }
          
            //ComboBoxEdit
            else if (control.GetType().Name == "ComboBoxEdit")
            {
                item.SetValue(obj, GetDefaultValue(((ComboBoxEdit)control).SelectedItem, item.PropertyType), null);

            }
          
            //ButtonEdit
            else if (control.GetType().Name == "ButtonEdit")
            {
                item.SetValue(obj, GetDefaultValue(((ButtonEdit)control).Text, item.PropertyType), null);

            }
            //Diğer   
            else
            {

            }


        }

    }

    /// <summary>
    /// Formu Temizler
    /// </summary>
    /// <param name="lc"></param>
    /// <param name="obj"></param>
    public static void FormClear(LayoutControl lc, object obj)
    {
        foreach (PropertyInfo item in obj.GetType().GetProperties())
        {

            Control control = lc.Controls["txt" + item.Name];
            if (control == null) continue;

            //TextEdit
            if (control.GetType().Name == "TextEdit")
            {
                ((TextEdit)control).Text = GetDefaultValue(null, item.PropertyType).ToString();
            }
            //TextEdit
            if (control.GetType().Name == "Button")
            {
                ((Button)control).Text = GetDefaultValue(null, item.PropertyType).ToString();
            }
     
            //MemoEdit
            else if (control.GetType().Name == "MemoEdit")
            {
                ((MemoEdit)control).Text = GetDefaultValue(null, item.PropertyType).ToString();
            }
            //LookUpEdit
            else if (control.GetType().Name == "LookUpEdit")
            {
                ((LookUpEdit)control).Properties.GetType().GetProperty("KeyValue").SetValue(((LookUpEdit)control).Properties, GetDefaultValue(null, typeof(Int32)), null);
            }//RadioGroup
            else if (control.GetType().Name == "RadioGroup")
            {
                ((RadioGroup)control).SelectedIndex = GetDefaultValue(null, item.PropertyType).ToInt();
            }
            //CheckEdit
            else if (control.GetType().Name == "CheckEdit")
            {
                ((CheckEdit)control).Checked = Convert.ToBoolean(GetDefaultValue(null, item.PropertyType));
            }//DateEdit
            else if (control.GetType().Name == "DateEdit")
            {
                ((DateEdit)control).DateTime = Convert.ToDateTime(GetDefaultValue(null, item.PropertyType));
            }
         
            //Diğer   
            else
            {

            }

        }
    }

    public static object GetDefaultValue(object _value, Type _type)
    {
        object Value = null;
        object DefaultValue = null;

        try
        {

            #region Değer Dönüş

            if (_type == typeof(double))
            {
                DefaultValue = 0;

                Value = _value.ToDbl();
            }

            else if (_type == typeof(decimal) || _type == typeof(Decimal))
            {
                DefaultValue = Convert.ToDecimal(0);
                Value = Convert.ToDecimal(_value);
            }
            else if (_type == typeof(string))
            {
                DefaultValue = string.Empty;
                Value = Convert.ToString(_value);
            }
            else if (_type == typeof(DateTime))
            {
                DefaultValue = DateTime.MinValue;
                Value = Convert.ToDateTime(_value);
            }
            else if (_type == typeof(DateTime?))
            {
                DefaultValue = null;
                try
                {

                    Value = Convert.ToDateTime(_value);
                    if ((DateTime)Value == DateTime.MinValue)
                        Value = null;
                }
                catch
                {

                    Value = null;
                }

            }
            else if (_type == typeof(bool))
            {
                DefaultValue = false;
                Value = Convert.ToBoolean(_value);
            }
            else if (_type == typeof(Int32))
            {
                DefaultValue = 0;
                Value = Convert.ToInt32(_value);
            }
            else
            {
                DefaultValue = string.Empty; ;
                Value = Convert.ToString(_value);
            }
            #endregion
        }
        catch
        {

            Value = DefaultValue;
        }
        return Value;
    }

    public static string BlankControl(LayoutControl LC, object obj, Dictionary<string, string> List)
    {
        string Mesaj = string.Empty;

        foreach (PropertyInfo item in obj.GetType().GetProperties())
        {
            int index = 0;
            if (List.ContainsKey(item.Name))
            {
                string Default = GetDefaultValue(null, item.PropertyType).ToString();
                string Value = item.GetValue(obj, null).ToStr();
                if (Default == Value)
                {
                    Mesaj += List[item.Name] + "\n";
                }
            }
        }

        return Mesaj;
    }




    public static void LookUp(DataTable dt, LookUpEdit lookUp, string ValueMember, string DisplayMember, string DisplayCaption)
    {
        lookUp.Properties.Columns.Clear();
        lookUp.Properties.DataSource = dt;
        lookUp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(ValueMember));
        lookUp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayMember, DisplayCaption));
        lookUp.Properties.Columns[ValueMember].Visible = false;

        lookUp.Properties.ValueMember = ValueMember;
        lookUp.Properties.DisplayMember = DisplayMember;

    }

    public static void LookUp(DataTable dt, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUp, string ValueMember, string DisplayMember, string DisplayCaption)
    {
        lookUp.Columns.Clear();
        lookUp.DataSource = dt;
        lookUp.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(ValueMember));
        lookUp.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayMember, DisplayCaption));
        lookUp.Columns[ValueMember].Visible = false;
        lookUp.ValueMember = ValueMember;
        lookUp.DisplayMember = DisplayMember;
    }


    public static void ExportExcel(GridView view, string fileName)
    {
        string temp = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + (DateTime.Now.ToLongTimeString() + DateTime.Now.ToShortDateString()).Replace(" ", "").Replace(".", "").Replace(":", "").Replace("/", "").Replace("\\", "") + fileName + ".xlt";

        string normalFile = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + fileName + ".xlt";

        if (File.Exists(normalFile))
        {
            try
            {
                File.Delete(normalFile);
            }
            catch { }
        }


        try
        {

            view.ExportToXls(normalFile);
            Process.Start(normalFile);
            try
            {
                //  File.Delete(normalFile);
            }
            catch { }
        }
        catch
        {
            view.ExportToXls(temp);
            Process.Start(temp);
            try
            {
                // File.Delete(temp);
            }
            catch { }
        }


    }
    public static void ExportPDF(GridView view, string fileName)
    {
        string temp = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + (DateTime.Now.ToLongTimeString() + DateTime.Now.ToShortDateString()).Replace(" ", "").Replace(".", "").Replace(":", "").Replace("/", "").Replace("\\", "") + fileName + ".pdf";

        string normalFile = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + fileName + ".pdf";

        if (File.Exists(normalFile))
        {
            try
            {
                File.Delete(normalFile);
            }
            catch { }
        }


        try
        {

            view.ExportToPdf(normalFile);
            Process.Start(normalFile);
            try
            {
                //  File.Delete(normalFile);
            }
            catch { }
        }
        catch
        {
            view.ExportToPdf(temp);
            Process.Start(temp);
            try
            {
                //  File.Delete(temp);
            }
            catch { }
        }


    }
    public static void ExportExcel(TreeList view, string fileName)
    {
        string temp = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + (DateTime.Now.ToLongTimeString() + DateTime.Now.ToShortDateString()).Replace(" ", "").Replace(".", "").Replace(":", "").Replace("/", "").Replace("\\", "") + fileName + ".xlt";

        string normalFile = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + fileName + ".xlt";

        if (File.Exists(normalFile))
        {
            try
            {
                File.Delete(normalFile);
            }
            catch { }
        }


        try
        {

            view.ExportToXls(normalFile);
            Process.Start(normalFile);
            try
            {
                //  File.Delete(normalFile);
            }
            catch { }
        }
        catch
        {
            view.ExportToXls(temp);
            Process.Start(temp);
            try
            {
                // File.Delete(temp);
            }
            catch { }
        }


    }
    public static void ExportPDF(TreeList view, string fileName)
    {
        string temp = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + (DateTime.Now.ToLongTimeString() + DateTime.Now.ToShortDateString()).Replace(" ", "").Replace(".", "").Replace(":", "").Replace("/", "").Replace("\\", "") + fileName + ".pdf";

        string normalFile = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + fileName + ".pdf";

        if (File.Exists(normalFile))
        {
            try
            {
                File.Delete(normalFile);
            }
            catch { }
        }


        try
        {

            view.ExportToPdf(normalFile);
            Process.Start(normalFile);
            try
            {
                // File.Delete(normalFile);
            }
            catch { }
        }
        catch
        {
            view.ExportToPdf(temp);
            Process.Start(temp);
            try
            {
                // File.Delete(temp);
            }
            catch { }
        }


    }

    public static void LookUp(DataTable dt, GridLookUpEdit lookUp, string ValueMember, string DisplayMember)
    {

        lookUp.Properties.DataSource = dt;

        lookUp.Properties.ValueMember = ValueMember;
        lookUp.Properties.DisplayMember = DisplayMember;

        foreach (DataColumn dCol in dt.Columns)
        {
            DevExpress.XtraGrid.Columns.GridColumn aColumn = lookUp.Properties.View.Columns.AddField(dCol.ColumnName);
            aColumn.Visible = true;
        }
        lookUp.Properties.View.OptionsView.ShowAutoFilterRow = true;
    }

    public static void LookUp(DataTable dt, RepositoryItemGridLookUpEdit lookUp, string ValueMember, string DisplayMember)
    {

        lookUp.DataSource = dt;

        lookUp.ValueMember = ValueMember;
        lookUp.DisplayMember = DisplayMember;

        foreach (DataColumn dCol in dt.Columns)
        {
            DevExpress.XtraGrid.Columns.GridColumn aColumn = lookUp.View.Columns.AddField(dCol.ColumnName);
            aColumn.Visible = true;
        }
        lookUp.View.OptionsView.ShowAutoFilterRow = true;
    }
    public static void CheckComboBox(DataTable dt, CheckedComboBoxEdit lookUp, string ValueMember, string DisplayMember)
    {

        lookUp.Properties.DataSource = dt;

        lookUp.Properties.ValueMember = ValueMember;
        lookUp.Properties.DisplayMember = DisplayMember;



    }




}


