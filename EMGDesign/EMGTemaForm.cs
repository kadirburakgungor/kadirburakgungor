using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Ribbon;
using EMGDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMGDesign
{
    public partial class EMGTemaForm : Form
    {
        DefaultLookAndFeel defaultLookAndFeel1;
        string defaultDeger;
        bool tamamlanma = false;
        public EMGTemaForm(DefaultLookAndFeel defaultLook)
        {
            InitializeComponent();
            defaultLookAndFeel1 = defaultLook;

            GalleryControl gallery = new GalleryControl();
            SkinHelper.InitSkinGallery(gallery, true);

            ImageCollection images = new ImageCollection();
            imageList.ImageList = images;
            tamamlanma = false;
            foreach (GalleryItem item in gallery.Gallery.GetAllItems())
            {
                images.AddImage(item.Image);

                imageList.Items.Add(item.Caption, images.Images.Count - 1);

                if (defaultLookAndFeel1.LookAndFeel.SkinName == item.Caption)
                {
                    imageList.SelectedItem = imageList.Items[imageList.Items.Count - 1];
                }
            }
            tamamlanma = true;
            defaultDeger = defaultLookAndFeel1.LookAndFeel.SkinName;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            defaultLookAndFeel1.LookAndFeel.SkinName = defaultDeger;
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            defaultLookAndFeel1.LookAndFeel.SkinName = imageList.SelectedValue.ToStr();

        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!tamamlanma) return;

            if (imageList.SelectedValue == null)
            {
                defaultLookAndFeel1.LookAndFeel.SkinName = defaultDeger;
                return;
            }
            defaultLookAndFeel1.LookAndFeel.SkinName = imageList.SelectedValue.ToStr();
        }

        private void frmTema_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }

        private void frmTema_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                if (imageList.SelectedValue == null)
                {
                    defaultLookAndFeel1.LookAndFeel.SkinName = defaultDeger;
                }
                defaultLookAndFeel1.LookAndFeel.SkinName = imageList.SelectedValue.ToStr();
            }
            else
            {
                defaultLookAndFeel1.LookAndFeel.SkinName = defaultDeger;
            }
        }
    }
}

public class MyBarLocalizer : BarLocalizer
{
    public override string GetLocalizedString(BarString id)
    {
        if (id == BarString.SkinCaptions)
        {
            //Default value for BarString.SkinCaptions:
            //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
            string defaultSkinCaptions = base.GetLocalizedString(id);
            string newSkinCaptions = defaultSkinCaptions.Replace("|DevExpress Style|", "|DevExpress|");
            return newSkinCaptions;
        }
        return base.GetLocalizedString(id);
    }
}

public static class EMGTema
{
    public static void Secim(DefaultLookAndFeel defaultLookAndFeel)
    {
        new EMGTemaForm(defaultLookAndFeel).ShowDialog();
    }

    public static void Kaydet(DefaultLookAndFeel defaultLookAndFeel, string dosyaAdi)
    {
        StreamWriter sw = new StreamWriter(dosyaAdi);
        sw.WriteLine(defaultLookAndFeel.LookAndFeel.SkinName);
        sw.Close();
    }

    public static void Oku(DefaultLookAndFeel defaultLookAndFeel, string dosyaAdi)
    {
        if (File.Exists(dosyaAdi))
        {
            try
            {
                StreamReader sr = new StreamReader(dosyaAdi);
                defaultLookAndFeel.LookAndFeel.SkinName = sr.ReadLine();
                sr.Close();
            }
            catch { }
        }

    }
}