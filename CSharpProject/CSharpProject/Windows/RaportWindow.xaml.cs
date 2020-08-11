using ClosedXML.Excel;
using CSharpProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;


namespace CSharpProject.Windows
{
    
    public partial class RaportWindow : Window
    {
        private readonly LibrariyContext _context;
        
        public RaportWindow()
        {
            InitializeComponent();
            _context = new LibrariyContext();
            FillRaportData();
        }

        //Fill raports Data
        private void FillRaportData()
        {
            DgvRaport.ItemsSource = _context.Carts.Include(x => x.Customer).ToList();
             
        }

        //Serach Intervall
        private void BtnSerachInterval_Click(object sender, RoutedEventArgs e)
        {
            if (DtpStartTime.SelectedDate == null || DtpEndTime.SelectedDate == null)
            {
                FillRaportData();
                return;
            }
            DateTime startTime = (DateTime)DtpStartTime.SelectedDate;
            DateTime endTime = (DateTime)DtpEndTime.SelectedDate;

            var carts = _context.Carts.Where(x => x.WithdrawalDate >= startTime && x.ExpirationDate <= endTime).ToList();

            DgvRaport.ItemsSource = carts;
        }

        //Show All Data
        private void BtnAllData_Click(object sender, RoutedEventArgs e)
        {
            FillRaportData();
        }

        //Export To Excell
        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "Raport.xlsx";
            fileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(fileDialog.FileName))
            {
                SaveExcell(fileDialog.FileName);
            }


        }

        //Create Excell Fayl
        private void SaveExcell(string path)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Raports");
                worksheet.Cell("A1").Value = "Id";
                worksheet.Cell("B1").Value = "Kitab Adı";
                worksheet.Cell("C1").Value = "Qiyməti";
                worksheet.Cell("D1").Value = "Müştəri Adı";
                worksheet.Cell("E1").Value = "Götürmə Vaxtı";
                worksheet.Cell("F1").Value = "Geri Qaytarma vaxtı";
                worksheet.Cell("G1").Value = "Gecikmə Vaxtı";

                worksheet.Row(1).Style.Fill.SetBackgroundColor(XLColor.AppleGreen);
                worksheet.Row(1).Style.Font.SetFontColor(XLColor.White);

                worksheet.Row(1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Row(2).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(3).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(4).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(5).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(6).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(7).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(8).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(9).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(10).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                worksheet.Row(11).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);


                worksheet.Column(1).Width = 10;
                worksheet.Column(2).Width = 20;
                worksheet.Column(3).Width = 30;
                worksheet.Column(4).Width = 30;
                worksheet.Column(5).Width = 30;
                worksheet.Column(6).Width = 30;
                worksheet.Column(7).Width = 30;

                int row = 2;

                foreach (var cart in _context.Carts.ToList())
                {
                    worksheet.Cell("A" + row).Value = cart.Id;
                    worksheet.Cell("B" + row).Value = cart.Name;
                    worksheet.Cell("C" + row).Value = cart.Price + " azn";
                    worksheet.Cell("D" + row).Value = cart.Customer.Name;
                    worksheet.Cell("E" + row).Value = cart.WithdrawalDate;
                    worksheet.Cell("F" + row).Value = cart.ExpirationDate;
                    worksheet.Cell("G" + row).Value = cart.DelayTime;

                    row++;
                }

                MessageBox.Show("Excell faylı yaradıldı");
                workbook.SaveAs(path);
                
            }
        }
    }
}
