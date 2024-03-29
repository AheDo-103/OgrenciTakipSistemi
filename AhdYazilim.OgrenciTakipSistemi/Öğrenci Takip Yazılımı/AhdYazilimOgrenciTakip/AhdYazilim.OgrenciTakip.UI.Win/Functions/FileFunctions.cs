﻿using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace AhdYazilim.OgrenciTakip.UI.Win.Functions
{
    public static class FileFunctions
    {
        public static void FormSablonKaydet(this string sablonAdi, int left, int top, int width, int height, FormWindowState windowState)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");

                var settings = new XmlWriterSettings() { Indent = true };
                var writer = XmlWriter.Create(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml", settings);

                writer.WriteStartDocument();
                writer.WriteComment("AHD Yazılım Tarafından Oluşturuldu.");

                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("Left", left.ToString());
                writer.WriteAttributeString("Top", top.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("FormSize");
                if (windowState == FormWindowState.Maximized)
                {
                    writer.WriteAttributeString("Width", "-1");
                    writer.WriteAttributeString("Height", "-1");
                }
                else
                {
                    writer.WriteAttributeString("Width", width.ToString());
                    writer.WriteAttributeString("Height", height.ToString());
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void FormSablonYukle(this string sablonAdi, XtraForm frm)
        {
            var list = new List<string>();

            try
            {
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml"))
                {
                    var reader = XmlReader.Create(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                    }

                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }

            if (list.Count <= 0) return;
            frm.Location = new Point(int.Parse(list[0]), int.Parse(list[1]));

            if (list[2] == "-1" && list[3] == "-1")
                frm.WindowState = FormWindowState.Maximized;
            else
                frm.Size = new Size(int.Parse(list[2]), int.Parse(list[3]));
        }

        public static void TabloSablonKaydet(this GridView tablo, string sablonAdi)
        {
            try
            {
                tablo.ClearColumnsFilter();

                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");

                tablo.SaveLayoutToXml(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml");
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void TabloSablonYukle(this GridView tablo, string sablonAdi)
        {
            try
            {
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml"))
                    tablo.RestoreLayoutFromXml(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml");
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void TabloDisariAktar(this GridView tablo, DosyaTuru dosyaTuru, string dosyaFormati, string excelSayfaAdi = null)
        {
            if (Messages.TabloExportMesaj(dosyaFormati) != DialogResult.Yes)
                return;

            if (!Directory.Exists(Application.StartupPath + @"\Temp"))
                Directory.CreateDirectory(Application.StartupPath + @"\Temp");

            var dosyaAdi = Guid.NewGuid().ToString();
            var filePath = $@"{Application.StartupPath}\Temp\{dosyaAdi}";

            switch (dosyaTuru)
            {
                case DosyaTuru.ExcelStandart:
                    {
                        var options = new XlsxExportOptionsEx()
                        {
                            ExportType = ExportType.Default,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text,
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, options);
                    }
                    break;
                case DosyaTuru.ExcelFormatli:
                    {
                        var options = new XlsxExportOptionsEx()
                        {
                            ExportType = ExportType.WYSIWYG,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, options);
                    }
                    break;
                case DosyaTuru.ExcelFormatsiz:
                    {
                        var options = new CsvExportOptionsEx()
                        {
                            ExportType = ExportType.Default,
                            TextExportMode = TextExportMode.Text,
                        };

                        filePath = filePath + ".Csv";
                        tablo.ExportToCsv(filePath, options);
                    }
                    break;
                case DosyaTuru.WordDosyasi:
                    {
                        filePath = filePath + ".Rtf";
                        tablo.ExportToRtf(filePath);
                    }
                    break;
                case DosyaTuru.PdfDosyayi:
                    {
                        filePath = filePath + ".Pdf";
                        tablo.ExportToPdf(filePath);
                    }
                    break;
                case DosyaTuru.TxtDosyasi:
                    {
                        var options = new TextExportOptions() { TextExportMode = TextExportMode.Text };

                        filePath = filePath + ".Txt";
                        tablo.ExportToText(filePath, options);
                    }
                    break;
            }

            if (!File.Exists(filePath))
            {
                Messages.HataMesaji("Tablo Verileri Dosyaya Aktarılamadı.");
                return;
            }

            Process.Start(filePath);
        }
    }
}